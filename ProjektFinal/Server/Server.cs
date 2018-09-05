using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.TcpMessagingSystem;
using Eneter.Messaging.Threading.Dispatching;
using ProjektFinal.Server;
using BazaDanychMySQL;

namespace WinFormServiceApplication
{
    public struct DataReceived
    {
        public DateTime timestamp;
        public float temperature;
        public float humidity;
        public float pressure;
    }
    public class Server
    {

        // Receive string messages and send back string messages.
        IDuplexTypedMessageReceiver<MyResponse, MyRequest> myReceiver;
        public SerialConnect.Serial Serial { get; set; }
        public DBConnect Baza { get; set; }
        public string ServerIp { get; set; }

        List<Client> clients;

        public delegate void SendClientConnectionStatus(object sender, ResponseReceiverEventArgs e);
        public event SendClientConnectionStatus SendConnectedClient;

        public delegate void SendClientDisconnectionStatus(object sender, ResponseReceiverEventArgs e);
        public event SendClientDisconnectionStatus SenDisconnectedClient;

        public delegate void SendLedConfirmation(object sender, LedSerialArgs e);
        public event SendLedConfirmation SendLedInfo;


        //pomocnicze dla serwera, w przypadku gdy użytkownik chce od nas ostatnią próbkę - nie zwracamy jej z bazy tylko z poniższej listy
        public object sampleMutex;
        public List<DataReceived> dataReceiveds;
        public Server()
        {

            sampleMutex = new object();
            dataReceiveds = new List<DataReceived>();
            // Create message receiver.
            IDuplexTypedMessagesFactory aReceiverFactory = new DuplexTypedMessagesFactory();
            myReceiver = aReceiverFactory.CreateDuplexTypedMessageReceiver<MyResponse, MyRequest>();

            clients = new List<Client>();
            myReceiver.ResponseReceiverConnected += OnClientConnected;
            myReceiver.ResponseReceiverDisconnected += OnClientDisconnected;
            myReceiver.MessageReceived += OnMessageReceived;
        }
        public void Close()
        {
            // Detach input channel and stop listening.
            clients.Clear();
            myReceiver.DetachDuplexInputChannel();
        }

        private void OnClientConnected(object sender, ResponseReceiverEventArgs e)
        {
            // Add the client id to the listbox.
            // Note: we can directly access the listbox because we set threading mode of
            //       InputChannelThreading to the main UI thread.
            //ConnectedClientsListBox.Items.Add(e.ResponseReceiverId);
            Client client = new Client(e.ResponseReceiverId, e.SenderAddress);
            clients.Add(client);

            SendConnectedClient?.Invoke(sender, e);
        }

        private void OnClientDisconnected(object sender, ResponseReceiverEventArgs e)
        {
            // Remove the client from the listbox.
            // Note: we can directly access the listbox because we set threading mode of
            //       InputChannelThreading to the main UI thread.
            //ConnectedClientsListBox.Items.Remove(e.ResponseReceiverId);
            Client temp = null;
            foreach(Client client in clients)
            {
                if(client.id == e.ResponseReceiverId)
                {
                    client.Disconnect();
                    temp = client;

                    SenDisconnectedClient?.Invoke(sender, e);
                    break;
                }
            }

            if(temp!=null)
                clients.Remove(temp);
        }

        private Client GetClient(string id)
        {
            foreach (Client client in clients)
            {
                if (client.id == id)
                {
                    return client;
                }
            }
            return null;
        }

        private MyResponse SendWeatherInfo(timespan ts, int count)
        {
            MyResponse resp;
            if (ts == timespan.sample)
            {
                lock (sampleMutex)
                {
                    if(count < dataReceiveds.Count)
                    {
                        DataReceived temp = dataReceiveds[(dataReceiveds.Count - count)];
                        resp = new MyResponse() { Time = (int)temp.timestamp.Subtract(new DateTime(1970, 1, 1)).TotalSeconds, Temperature = temp.temperature, Humidity = temp.humidity, Pressure = temp.pressure };
                    }
                    else
                    {
                        if(dataReceiveds.Count > 0)
                        {
                            DataReceived temp = dataReceiveds[0];
                            resp = new MyResponse() { Time = (int)temp.timestamp.Subtract(new DateTime(1970, 1, 1)).TotalSeconds, Temperature = temp.temperature, Humidity = temp.humidity, Pressure = temp.pressure };
                        }
                        else
                        {
                            return null;
                        }
                    }
                    
                    

                }
                return resp;
            }
            else
            {
                string query = Baza.CreateSelectQuery(ts, count, true);

                List<string>[] result = new List<string>[4];
                result = Baza.Select(query);


                try
                {
                    DateTime lol = DateTime.Parse(result[0][0]);
                    resp = new MyResponse();
                    resp.Temperature = Convert.ToSingle((result[1][0]));
                    resp.Pressure = Convert.ToSingle(result[2][0]);
                    resp.Humidity = Convert.ToSingle(result[3][0]);
                    resp.Time = (Int32)(lol.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

                    return resp;
                }
                catch (ArgumentNullException ex)
                {
                    return null;
                    //MessageBox.Show("Brak argumentu " + ex);
                }
                catch (FormatException ex)
                {
                    return null;
                    //MessageBox.Show("Błąd formatu: " + ex);
                }
                catch (OverflowException ex)
                {
                    return null;
                    //MessageBox.Show("Błąd przepełnienia " + ex);
                }
            }
        }
        private void OnMessageReceived(object sender, TypedRequestReceivedEventArgs<MyRequest> e)
        {
            if (e.RequestMessage.Ack == false)
            {
                MyResponse resp = SendWeatherInfo(e.RequestMessage.TimeUnit, e.RequestMessage.numberOfTimeUnitsBack);
                // Send message to client which is selected in the listbox.
                if(resp != null)
                {
                    myReceiver.SendResponseMessage(e.ResponseReceiverId, resp);
                }
            }
            else
            {
                if (Serial.IsOpen)
                {
                    
                    if (clients.IndexOf(GetClient(e.ResponseReceiverId)) != null)
                    {
                        int clientNumver = clients.IndexOf(GetClient(e.ResponseReceiverId));
                        Serial.Write((clientNumver + 1).ToString() + "#");
                        LedSerialArgs led = new LedSerialArgs(clientNumver + 1);
                        SendLedInfo?.Invoke(null, led);
                    }
                    else
                    { return; }
                    
                }
            }
        }

        public void Start()
        {
            if (myReceiver.IsDuplexInputChannelAttached)
            {
                // The channel is already attached so nothing to do.
                return;
            }

            // Use TCP communication
            IMessagingSystemFactory aMessaging = new TcpMessagingSystemFactory()
            {
                // Set to receive messages in the main UI thread.
                // Note: if this is not set then methods OnMessageReceived, OnClientConnected
                //       and OnClientDisconnected would not be called from main UI thread
                //       but from a listener thread.
                MaxAmountOfConnections = 5,
                //InputChannelThreading = new AsyncDispatching();
                //TODO
                // InputChannelThreading = new WinFormsDispatching(this)
            };

            // Create input channel.
            IDuplexInputChannel anInputChannel = aMessaging.CreateDuplexInputChannel(ServerIp);

            // Attach the input channel and be able to receive messages
            // and send back response messages.
            myReceiver.AttachDuplexInputChannel(anInputChannel);
        }

        public void Send(string aClientId, string message)
        {
            if (!string.IsNullOrEmpty(aClientId))
            {
                MyResponse resp = new MyResponse();
                //resp.Length = ReceivedMessagesListBox.Items[0].ToString().Length;
                // Send message to client which is selected in the listbox.
                myReceiver.SendResponseMessage(aClientId, resp);
            }
        }

        public void Disconnect(string aClientId)
        {
            if (!string.IsNullOrEmpty(aClientId))
            {
                myReceiver.AttachedDuplexInputChannel.DisconnectResponseReceiver(aClientId);
                Client temp = GetClient(aClientId);
                if (temp != null)
                {
                    clients.Remove(temp);
                    ResponseReceiverEventArgs e = new ResponseReceiverEventArgs(aClientId,"");
                    SenDisconnectedClient?.Invoke(null, e);
                }
            }
        }
    }
}
