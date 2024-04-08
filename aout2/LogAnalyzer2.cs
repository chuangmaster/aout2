using aout2;
using aout2.Services.Interfaces;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer2
    {
        public IWebService _WebService { get; set; }
        public IEmailService _EmailService { get; set; }

        public LogAnalyzer2(IWebService webService, IEmailService emailService)
        {
            _WebService = webService;
            _EmailService = emailService;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                try
                {
                    _WebService.LogError("Filename is too short:" + fileName);
                }
                catch (Exception e)
                {
                    _EmailService.SendEmail(new EmailInfo
                    {
                        To = "test@gmail.com",
                        Subject = "Log Error", 
                        Body =  e.Message
                    });
                }
            }
        }

    }
}