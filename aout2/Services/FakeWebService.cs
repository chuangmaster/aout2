using aout2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2.Services
{
    public class FakeWebService : IWebService
    {
        public string LastError { get; set; }
        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
