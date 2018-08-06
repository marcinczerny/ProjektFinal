using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektFinal.Server
{
    class Client
    {
        public readonly string id;
        public string ip;
        static int count;

        public void Disconnect()
        {
            count--;
        }

        public Client(string id, string ip)
        {
            this.id = id;
            this.ip = ip;
            count++;
        }

        public static int Count()
        {
            return count;
        }
    }
}
