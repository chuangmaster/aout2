using aout2;
using aout2.Services;
using aout2.Services.Interfaces;
using LogAn;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
namespace UnitTestProject1
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_WebServiceThrowException_SendEmail()
        {

            FakeWebService mockWebService = new FakeWebService();
            mockWebService.ToThrow = new System.Exception("An error occurred and was recorded in the log files");
            EmailInfo expectedMailInfo = new EmailInfo()
            {
                To = "test@gmail.com",
                Subject = "Log Error",
                Body = "An error occurred and was recorded in the log files"
            };
            FakeEmailService mockMailService = new FakeEmailService();
           
            LogAnalyzer2 log = new LogAnalyzer2(mockWebService, mockMailService);
            string tooShortFileName = "err.ext";
            log.Analyze(tooShortFileName);
            var expectedJson = JsonConvert.SerializeObject(expectedMailInfo);
            var actualJson = JsonConvert.SerializeObject(mockMailService.MailInfo);
            StringAssert.Contains(expectedJson, actualJson);
        }
    }
}