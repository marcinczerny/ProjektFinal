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

namespace ProjektFinal
{
    public partial class FormOptions : Form
    {
        public Serial serial { get; set; }
        string leftInBuffer;
        string[] baundRate = { "300", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400" };
        public FormOptions()
        {
            InitializeComponent();
            foreach (string baud in baundRate)
            {
                cmbBaudRate.Items.Add(baud);
            }

            cmbBaudRate.SelectedIndex = 4;

            foreach (string port in Serial.GetPortNames())
            {
                cmbPort.Items.Add(port);
            }

            txbBeginOfHumidity.Text = Properties.Settings.Default.charBeginOfHumidity;
            txbBeginOfPressure.Text = Properties.Settings.Default.charBeginOfPressure;
            txbEndOfFrame.Text = Properties.Settings.Default.charEndOfSerialFrame;
            txbBeginOfTemperature.Text = Properties.Settings.Default.charBeginOfTemperature;
        }

        
        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnStartSerialTest_Click(object sender, EventArgs e)
        {
            btnStartSerialTest.Enabled = false;
            
            btnConnect.Enabled = true;
           
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
            if (serial.IsOpen == false)
            {
                string port = cmbPort.SelectedItem.ToString();
                port = port.Substring(0, port.IndexOf(' '));

                int baud;
                Int32.TryParse(cmbBaudRate.SelectedItem.ToString(), out baud);
                serial.Open(port, baud);

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                btnConnect.Enabled = false;
            }
            else
            {
                serial.Close();
                btnConnect.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
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
                this.txbTemperatura.BeginInvoke(d, new object[] { dane });  //tutej
            }
            else
            {
                //textBox1.Text += dane;
                bool result;


                dane = leftInBuffer + dane;
                leftInBuffer = dane;
                do
                {
                    result = serial.DecodeMessage(ref dane);

                    if (result)
                    {
                        txbTemperatura.Text = serial.temperature.ToString();
                        txbCisnienie.Text = serial.pressure.ToString();
                        txbWilgotnosc.Text = serial.humidity.ToString();
                    }

                } while (result == true);
                textBox1.Text += dane;
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

        private void txbEndOfFrame_TextChanged(object sender, EventArgs e)
        {
            if (!String.Equals(txbEndOfFrame.Text, Properties.Settings.Default.charEndOfSerialFrame))
            {
                Properties.Settings.Default.charEndOfSerialFrame = txbEndOfFrame.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txbBeginOfTemperature_TextChanged(object sender, EventArgs e)
        {
            if (!String.Equals(txbBeginOfTemperature.Text, Properties.Settings.Default.charBeginOfTemperature))
            {
                Properties.Settings.Default.charBeginOfTemperature = txbBeginOfTemperature.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txbBeginOfPressure_TextChanged(object sender, EventArgs e)
        {
            if (!String.Equals(txbBeginOfPressure.Text, Properties.Settings.Default.charBeginOfPressure))
            {
                Properties.Settings.Default.charBeginOfPressure = txbBeginOfPressure.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txbBeginOfHumidity_TextChanged(object sender, EventArgs e)
        {
            if (!String.Equals(txbBeginOfHumidity.Text, Properties.Settings.Default.charBeginOfHumidity))
            {
                Properties.Settings.Default.charBeginOfHumidity = txbBeginOfHumidity.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
