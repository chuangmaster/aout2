using aout2;
using aout2.Services;
using LogAn;
using NUnit.Framework;
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
            FakeEmailService mockMailService = new FakeEmailService();
            LogAnalyzer2 log = new LogAnalyzer2(mockWebService, mockMailService);
            string tooShortFileName = "err.ext";
            log.Analyze(tooShortFileName);
            StringAssert.Contains("test@gmail.com", mockMailService.To);
            StringAssert.Contains("Log Error", mockMailService.Subject);
            StringAssert.Contains("An error occurred and was recorded in the log files", mockMailService.Body);
        }
    }
}