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

            mng = new ManageForms();
            serial = SerialFactory.CreateSerial(this.serialPort1);
        }

        private void konfiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mng.FormOpened() == false)
             mng.ViewOptions(serial);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Close();
        }
    }
}
