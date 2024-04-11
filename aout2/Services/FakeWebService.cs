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
        public string MessageToWebService { get; set; }
        public void Write(string message)
        {
            MessageToWebService = message;
        }

        public void Write(ErrorInfo info)
        {
            MessageToWebService = info.Message;
        }
    }
}
