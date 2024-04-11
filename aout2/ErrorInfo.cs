using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class ErrorInfo
    {
        public int Severity { get; set; }

        public string Message { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ErrorInfo info)
            {
                return info.Severity == Severity && info.Message == Message;
            }
            return false
        }
    }
}
