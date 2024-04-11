using aout2;
using aout2.Services;
using aout2.Services.Interfaces;
using LogAn;
using Newtonsoft.Json;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
namespace UnitTestProject1
{
    [TestFixture]
    public class LogAnalyzer2Tests
    {
        [Test]
        public void Analyze_LoggerThrows_CallsWebService()
        {

            IWebService mockWebService = Substitute.For<IWebService>();
            ILogger mockLogger = Substitute.For<ILogger>();
            mockLogger.When(x => x.LogError(Arg.Any<string>())).Do(context =>
            {
                throw new Exception("fake exception");
            });

            LogAnalyzer2 analyzer = new LogAnalyzer2(mockWebService, mockLogger);
            analyzer.MinNameLength = 10;
            string tooShortFileName = "short.ext";
            analyzer.Analyze(tooShortFileName);
            mockWebService.Received().Write(Arg.Is<string>(s=>s.Contains("fake exception")));
        }

        [Test]
        public void Analyze_LoggerThrowsExcpetion()
        {

            IWebService mockWebService = Substitute.For<IWebService>();
            ILogger mockLogger = Substitute.For<ILogger>();
            mockLogger.When(x => x.LogError(Arg.Any<string>())).Do(context =>
            {
                throw new Exception("fake exception");
            });

            LogAnalyzer2 analyzer = new LogAnalyzer2(mockWebService, mockLogger);
            analyzer.MinNameLength = 10;
            string tooShortFileName = "short.ext";
            //測試當直接拋錯誤
            Assert.Throws<Exception>(() => analyzer.Analyze(tooShortFileName));
        }
    }
}