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
    public partial class LedLight : UserControl
    {
        public LedLight()
        {
            InitializeComponent();
        }

        public void Start()
        {
            pictureDiode1.Image = Properties.Resources.diodeOn;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureDiode1.Image = Properties.Resources.diodeOff;
            timer1.Stop();
        }
    }
}
