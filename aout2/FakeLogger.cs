using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class FakeLogger : ILogger
    {
        public string LastError;
        public void Log(string message)
        {
            LastError = message;
        }
    }
}
