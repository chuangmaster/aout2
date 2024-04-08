using aout2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2.Services
{
    public class FakeEmailService : IEmailService
    {
        public EmailInfo MailInfo;
        public void SendEmail(EmailInfo emailInfo)
        {
            this.MailInfo = emailInfo;
        }
    }
}
