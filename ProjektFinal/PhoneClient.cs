using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektFinal
{
    public partial class PhoneClient : UserControl
    {
        public string ID { get; set; }
        public string Ip { get; set; }

        public bool Connected { get; set; }

        public delegate void SendDisconnectBtnPressed(object sender, EventArgs e);
        public event SendDisconnectBtnPressed SenDisconnectedClient;
        public PhoneClient()
        {
            InitializeComponent();
        }

        public void Connect()
        {
            lblIp.Text = Ip;
            btnDisconnect.Enabled = true;
            picturePhone.BackColor = Color.Green;
            Connected = true;
        }

        public void btnDisconnect_Click(object sender, EventArgs e)
        {
            SenDisconnectedClient?.Invoke(sender,e);
            //do implementacji
        }

        public void Disconnect()
        {
            picturePhone.BackColor = Color.DarkRed;
            btnDisconnect.Enabled = false;
            Connected = false;
        }
    }
}
