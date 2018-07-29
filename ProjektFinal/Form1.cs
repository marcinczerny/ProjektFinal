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
    public partial class Form1 : Form
    {
        ManageForms mng;
        Serial serial;
        string leftInBuffer;
        DBConnect baza;

        object serialMutex;
        public Form1()
        {
            InitializeComponent();

            mng = new ManageForms(this);
            serial = SerialFactory.CreateSerial(this.serialPort1);
            SetSerialPort();
            baza = new DBConnect();

            btnDisconnectSerial.Enabled = false;
            panelClosedSerial.BackColor = Color.Red;

            serialMutex = new object();
        }

        private void konfiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mng.FormOpened() == false)
            {
                mng.ViewOptions(serial);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Close();
        }

        public void SetSerialPort()
        {
            lblPortName.Text = Properties.Settings.Default.stringPortName;
            lblPortBaud.Text = Properties.Settings.Default.intBaudRate.ToString();
        }

        private void CloseSerialConnection()
        {
            serial.Close();
            panelClosedSerial.BackColor = Color.Red;
            panelOpenedSerial.BackColor = DefaultBackColor;
            btnConnectSerial.Enabled = true;
            btnDisconnectSerial.Enabled = false;
            pictureSerial.BackColor = Color.DarkRed;
            pictureBT.BackColor = Color.DarkRed;
            pictureUControler.BackColor = Color.DarkRed;
        }

        private void OpenSerialConnection()
        {
            if (mng.FormOpened() == true || serial.IsOpen)
            {
                return;
            }

            string port = Properties.Settings.Default.stringPortName;
            port = port.Substring(0, port.IndexOf(' '));
            try
            {
                serial.Open(port, Properties.Settings.Default.intBaudRate);
            }
            catch(System.IO.IOException ex)
            {
                    MessageBox.Show(ex.Message);
                    return;
             }
            btnDisconnectSerial.Enabled = true;
            btnConnectSerial.Enabled = false;
            panelClosedSerial.BackColor = DefaultBackColor;
            panelOpenedSerial.BackColor = Color.Green;
            pictureSerial.BackColor = Color.Green;
            pictureBT.BackColor = Color.Green;
            pictureUControler.BackColor = Color.Green;
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            OpenSerialConnection();
        }

        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            CloseSerialConnection();
        }

        /// <summary>
        /// Delegat do zapewnienia bezpieczeństwa wątków przy odbieraniu wiadomości
        /// </summary>
        /// <param name="data"></param>
        delegate void delegatForSerialportMsg(string data);
        private void SetText(string dane)
        {
            bool sendingSuccesfull;
            if (this.textBox1.InvokeRequired)
            {
                delegatForSerialportMsg d = new delegatForSerialportMsg(SetText); //dodanie delegata do kolejki
                this.textBox1.BeginInvoke(d, new object[] { dane });  //tutej
            }
            else
            {
                try
                {
                    textBox1.Text += dane; 
                }catch(ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        delegate void delegatForDatabase();
        private void SetInsertedToDBMessagesNumber()
        {
            bool sendingSuccesfull;
            if (this.numericUpDown1.InvokeRequired)
            {
                delegatForDatabase d = new delegatForDatabase(SetInsertedToDBMessagesNumber); //dodanie delegata do kolejki
                this.numericUpDown1.BeginInvoke(d, new object[] { });  //tutej
            }
            else
            {
                try
                {
                    numericUpDown1.Value = numericUpDown1.Value + 1;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            float temp, pres, hum;
            string query;


            bool result;
            string dane = serial.ReadMessage();
            SetText(dane);
            lock (serialMutex)
            {
                dane = leftInBuffer + dane;
                
                do
                {
                    result = serial.DecodeMessage(ref dane);

                    if (result)
                    {
                        SetInsertedToDBMessagesNumber();

                        temp = serial.temperature;
                        pres = serial.pressure;
                        hum = serial.humidity;
                        query = baza.CreateInsertQuery(temp, pres, hum);
                        baza.Insert(query);
                    }

                } while (result == true);

                leftInBuffer = dane;
            }
        }

        private void phoneClient1_Load(object sender, EventArgs e)
        {

        }
    }
}
