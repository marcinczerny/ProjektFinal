using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialConnect;
using BazaDanychMySQL;

namespace ProjektFinal
{
    public partial class FormOptions : Form
    {
        public Serial SerialContext { get; set; }
        public delegate void SendClickHandler(object sender, EventArgs e);
        public event SendClickHandler SendClick;


        private Serial serial;
        string leftInBuffer;
        string[] baundRate = { "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400" };

        DBConnect baza;
        bool bazaValidated;
        public FormOptions()
        {
            InitializeComponent();
            int index = -1;
            int pom = 0;
            foreach (string baud in baundRate)
            {
                cmbBaudRate.Items.Add(baud);
                if(Int32.Parse(baud) == Properties.Settings.Default.intBaudRate)
                {
                    index = pom;
                }
                pom++;
            }
            if (index != -1)
            {
                cmbBaudRate.SelectedIndex = index;
            }
            else
            {
                cmbBaudRate.SelectedIndex = 4;
            }

            index = -1;
            pom = 0;
            foreach (string port in Serial.GetPortNames())
            {
                cmbPort.Items.Add(port);
                if (String.Equals(port, Properties.Settings.Default.stringPortName))
                {
                    index = pom;
                }
                pom++;
            }
            if (index != -1)
            {
                cmbPort.SelectedIndex = index;
            }

            txbBeginOfHumidity.Text = Properties.Settings.Default.charBeginOfHumidity;
            txbBeginOfPressure.Text = Properties.Settings.Default.charBeginOfPressure;
            txbEndOfFrame.Text = Properties.Settings.Default.charEndOfSerialFrame;
            txbBeginOfTemperature.Text = Properties.Settings.Default.charBeginOfTemperature;

            baza = new DBConnect(Properties.Settings.Default.stringServer, Properties.Settings.Default.stringUID, Properties.Settings.Default.stringDBPassword, Properties.Settings.Default.stringDatabase);
            maskedPassword.Text = Properties.Settings.Default.stringDBPassword;
            txbServer.Text = Properties.Settings.Default.stringServer;
            txbUID.Text = Properties.Settings.Default.stringUID;
            txbDatabase.Text = Properties.Settings.Default.stringDatabase;

            bazaValidated = false;
        }

        
        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            serial.CopySerialSettings(SerialContext);
            serial.Close();
            SendClick?.Invoke(sender, e);
            this.Hide();
        }

        private void btnStartSerialTest_Click(object sender, EventArgs e)
        {
            btnStartSerialTest.Enabled = false;
            
            btnConnect.Enabled = true;
           
        }
        
        public void CopySerial()
        {
            serial = SerialConnect.SerialFactory.CopySerial(this.serialPort1, SerialContext);
        }
        private void bntCancelSerialTest_Click(object sender, EventArgs e)
        {
            serial.Close();
            btnStartSerialTest.Enabled = true;
            btnConnect.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen == false && SerialContext.IsOpen == false)
            {
                string port = cmbPort.SelectedItem.ToString();
                port = port.Substring(0, port.IndexOf(' '));

                int baud;
                Int32.TryParse(cmbBaudRate.SelectedItem.ToString(), out baud);
                serial.portName = port;
                serial.baudRate = baud;
                try
                {
                    serial.Open(port, baud);
                }catch(System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                btnConnect.Enabled = false;
                bntCancelSerialTest.Enabled = true;
                lblStatusSerial.Text = "Poprawnie połączono z portem szeregowym";
            }
            else
            {
                serial.Close();
                btnConnect.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                bntCancelSerialTest.Enabled = false;
                btnStartSerialTest.Enabled = true;
                lblStatusSerial.Text = "Nie udało się połączyć z portem szeregowym";
            }
        }

        /// <summary>
        /// Delegat do zapewnienia bezpieczeństwa wątków przy odbieraniu wiadomości
        /// </summary>
        /// <param name="data"></param>
        delegate void delegatForSerialportMsg(string data);
        private void SetText(string dane)
        {
            bool sendingSuccesfull;
            if (this.txbTemperatura.InvokeRequired)
            {
                delegatForSerialportMsg d = new delegatForSerialportMsg(SetText); //dodanie delegata do kolejki
                this.txbCisnienie.BeginInvoke(d, new object[] { dane });  //tutej
            }
            else
            {
                bool result;
                textBox1.Text += dane;
                dane = leftInBuffer + dane;
                do
                {
                    result = SerialContext.DecodeMessage(ref dane);

                    if (result)
                    {
                        txbTemperatura.Text = SerialContext.temperature.ToString();
                        txbCisnienie.Text = SerialContext.pressure.ToString();
                        txbWilgotnosc.Text = SerialContext.humidity.ToString();
                    }

                } while (result == true);
                leftInBuffer = dane;
                
            }
        }
        private void SendClient(string client)
        {
            serial.Write(client + "#");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SendClient("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendClient("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendClient("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendClient("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SendClient("5");
        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string result = serial.ReadMessage();
            SetText(result);
        }


        private void btnSaveFrame_Click(object sender, EventArgs e)
        {
            if (!String.Equals(txbEndOfFrame.Text, Properties.Settings.Default.charEndOfSerialFrame))
            {
                Properties.Settings.Default.charEndOfSerialFrame = txbEndOfFrame.Text;
                Properties.Settings.Default.Save();
            }
            if (!String.Equals(txbBeginOfTemperature.Text, Properties.Settings.Default.charBeginOfTemperature))
            {
                Properties.Settings.Default.charBeginOfTemperature = txbBeginOfTemperature.Text;
                Properties.Settings.Default.Save();
            }
            if (!String.Equals(txbBeginOfPressure.Text, Properties.Settings.Default.charBeginOfPressure))
            {
                Properties.Settings.Default.charBeginOfPressure = txbBeginOfPressure.Text;
                Properties.Settings.Default.Save();
            }
            if (!String.Equals(txbBeginOfHumidity.Text, Properties.Settings.Default.charBeginOfHumidity))
            {
                Properties.Settings.Default.charBeginOfHumidity = txbBeginOfHumidity.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnSaveSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.intBaudRate = Int32.Parse(cmbBaudRate.Text);
                Properties.Settings.Default.stringPortName = cmbPort.Text;
                Properties.Settings.Default.Save();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void ShowSerialStatus()
        {
            if (SerialContext.IsOpen)
            {
                lblStatusSerial.Text = "Jesteś połączony przez port szeregowy";
                btnStartSerialTest.Enabled = false;
                bntCancelSerialTest.Enabled = false;
            }
            else
            {
                lblStatusSerial.Text = "Nie jesteś połączony przez port szeregowy";
                btnStartSerialTest.Enabled = true;
                bntCancelSerialTest.Enabled = false;
            }
        }

        private void btnCheckCount_Click(object sender, EventArgs e)
        {
            nmrStatCount.Value = (decimal)(baza.Count());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int delete = (int)nmrDeleteCount.Value;
            if (delete < 1)
            {
                baza.Delete();
            }
            else
            {
                baza.Delete(delete);
            }

            btnCheckCount_Click(sender, e);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnValidateDB_Click(object sender, EventArgs e)
        {
            backgroundValidateDB.RunWorkerAsync();
        }

        private void txbServer_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringServer = txbServer.Text;
            Properties.Settings.Default.Save();
            baza.Server = Properties.Settings.Default.stringServer;
            baza.refreshConnection();
        }

        private void txbServer_Validated(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringServer = txbServer.Text;
            Properties.Settings.Default.Save();
            baza.Server = Properties.Settings.Default.stringServer;
            baza.refreshConnection();
        }

        private void txbUID_Validated(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringUID = txbUID.Text;
            Properties.Settings.Default.Save();
            baza.Uid = Properties.Settings.Default.stringUID;
            baza.refreshConnection();
        }

        private void maskedPassword_Validated(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringDBPassword = maskedPassword.Text;
            Properties.Settings.Default.Save();
            baza.Password = Properties.Settings.Default.stringDBPassword;
            baza.refreshConnection();
        }

        private void txbDatabase_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringDatabase = txbDatabase.Text;
            Properties.Settings.Default.Save();
            baza.Database = Properties.Settings.Default.stringDatabase;
            baza.refreshConnection();
        }

        private void backgroundValidateDB_DoWork(object sender, DoWorkEventArgs e)
        {
            if (baza.ValidateDB() == true)
            {
                bazaValidated = true;
            }
            else
            {
                bazaValidated = false;
            }
        }

        private void backgroundValidateDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bazaValidated == true)
            {
                MessageBox.Show("Walidacja przebiegła poprawnie");

            }
            else
            {
                MessageBox.Show("Walidacja zakończyła się niepowodzeniem!!!");
            }
            
            Cursor.Current = Cursors.Default;
        }
    }
}
