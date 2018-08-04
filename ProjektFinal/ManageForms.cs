using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFinal
{
    public class ManageForms
    {
        private FormOptions form;
        private Form1 mainForm;
        private bool formOpened;

        public delegate void SendClickHandler(object sender, EventArgs e);
        public event SendClickHandler SendClick;

        void formOptions_closed(object sender, EventArgs e)
        {
            mainForm.SetSerialPort();
            mainForm.ValidateApp();
            //SendClick?.Invoke(sender, e);
        }
        
        public ManageForms(Form1 form1)
        {
            mainForm = form1;
            form = new FormOptions();
            
            form.SendClick += new FormOptions.SendClickHandler(formOptions_closed);
        }
        public bool FormOpened()
        {
            if(form.Visible == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ViewOptions(SerialConnect.Serial Context)
        {
            form.SerialContext = Context;
            form.CopySerial();
            form.ShowSerialStatus();
            form.Show();
        }
    }
}
