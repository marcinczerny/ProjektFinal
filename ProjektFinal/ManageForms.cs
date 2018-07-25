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
        private bool formOpened;

        public ManageForms()
        {
            form = new FormOptions();
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
            form.serial = Context;
            form.Show();
        }
    }
}
