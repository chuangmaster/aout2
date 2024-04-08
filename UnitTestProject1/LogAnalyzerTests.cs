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
        public void OverrideTest() { 

            FakeWebService mockService = new FakeWebService();

            LogAnalyzer logAnalyzer = new LogAnalyzer(mockService);
            string tooShortFileName = "err.ext";
            logAnalyzer.Analyze(tooShortFileName);

            StringAssert.Contains("Filename is too short:err.ext", mockService.LastError);
            
        }
    }
}