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
    public partial class Form1 : Form
    {
        ManageForms mng;
        Serial serial;
        public Form1()
        {
            InitializeComponent();

            mng = new ManageForms(this);
            serial = SerialFactory.CreateSerial(this.serialPort1);
            SetSerialPort();
            btnDisconnectSerial.Enabled = false;
            panelClosedSerial.BackColor = Color.Red;
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
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            OpenSerialConnection();
        }

        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            CloseSerialConnection();
        }
    }
}
