using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class FakeLogger2 : ILogger
    {
        public Exception WillThrow { get; set; }
        public string LoggerGotMessage;
        public void LogError(string message)
        {
            LoggerGotMessage = message;
            if(WillThrow != null)
            {
                throw WillThrow;
            }
        }
    }
}
