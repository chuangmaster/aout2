using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class TimeLogger
    {
        public static string CreateMessage(string info)
        {
            return SystemTime.Now.ToShortDateString() + " " + info;
        }
    }
}
