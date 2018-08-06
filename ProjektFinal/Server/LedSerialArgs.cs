using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFinal.Server
{
    public class LedSerialArgs : EventArgs
    {
        public LedSerialArgs(int number)
        {
            LedNumber = number;
        }
        public int LedNumber { get; set; }
    }
}
