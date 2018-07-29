using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanychMySQL
{
    public static class Timestamp
    {
        public static long ConvertDateToTimeStamp(DateTimeOffset date )
        {
            return date.ToUnixTimeSeconds();
            date = new DateTimeOffset(DateTime.UtcNow,new TimeSpan(1,0,0));
        }
    }
}
