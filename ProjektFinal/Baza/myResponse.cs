using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanychMySQL
{
    public enum timespan { sample, minute, hour, day };
    public class myResponse
    {
        public bool Ack { get; set; }
        public timespan TimeUnit { get; set; }
        public int numberOfTimeUnitsBack { get; set; }
    }
}
