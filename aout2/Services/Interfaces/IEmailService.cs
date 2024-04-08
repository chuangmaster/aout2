using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2.Services.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(EmailInfo emailInfo);
    }

    public class EmailInfo
    {
        public string To;
        public string Subject;
        public string Body;
    }
}
