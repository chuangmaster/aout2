using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class SystemTime
    {
        private static DateTime _dateTime;
        public static void Set(DateTime dateTime)
        {
            _dateTime = dateTime;
        }
        public static void Reset()
        {
            _dateTime = DateTime.MinValue;
        }

        public static DateTime Now
        {

            get
            {
                if (_dateTime != DateTime.MinValue)
                {
                    return _dateTime;
                }
                return DateTime.Now;
            }
        }
    }
}
