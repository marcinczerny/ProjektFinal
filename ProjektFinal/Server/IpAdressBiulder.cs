using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjektFinal.Server
{
    public static class IpAdressBiulder
    {
        public static string CreateIpAdress(string ip, string port)
        {
            return "tcp://" + ip + ":" + port + "/";
        }

        public static string MakeShortIpAdress(string ip, string port)
        {
            return ip + ":" + port;
        }

        public static string GetPort(string ip)
        {
            return ip.Substring(Regex.Match(ip, @"\d+:\d+").Index + 2, 4);
        }

        public static string GetIp(string ip)
        {
            return ip.Substring(Regex.Match(ip, @"//").Index + 2, Regex.Match(ip,@"\d+:\d+").Index+1-(Regex.Match(ip, @"//").Index + 2));
        }
    }
}
