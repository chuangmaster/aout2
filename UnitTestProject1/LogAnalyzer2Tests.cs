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
    [Category("UnitTest")]
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
            mockWebService.Received().Write(Arg.Is<string>(s => s.Contains("fake exception")));
        }

        [Test]
        [Ignore]
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
        [Test]
        public void Analyze2_LoggerThrows_CallsWebServiceWithNSubObj()
        {
            //arrange
            IWebService mockWebService = Substitute.For<IWebService>();
            ILogger mockLogger = Substitute.For<ILogger>();
            mockLogger.When(logger =>
            {
                logger.LogError(Arg.Any<string>());
            }).Do(context =>
            {
                throw new Exception("fake exception");
            });
            LogAnalyzer2 logAnalyzer = new LogAnalyzer2(mockWebService, mockLogger);
            logAnalyzer.MinNameLength = 10;
            string tooShortFileName = "short.ext";
            logAnalyzer.Analyze2(tooShortFileName);

            mockWebService.Received().Write(
                Arg.Is<ErrorInfo>(info => info.Severity == 1000 && info.Message.Contains("fake exception")));
        }

        [Test]
        public void Analyze2_LoggerThrows_CallsWebServiceWithNSubObjectCompare()
        {
            //arrange
            IWebService mockWebService = Substitute.For<IWebService>();
            ILogger mockLogger = Substitute.For<ILogger>();
            mockLogger.When(logger =>
            {
                logger.LogError(Arg.Any<string>());
            }).Do(context =>
            {
                throw new Exception("fake exception");
            });
            LogAnalyzer2 logAnalyzer = new LogAnalyzer2(mockWebService, mockLogger);
            logAnalyzer.MinNameLength = 10;
            string tooShortFileName = "short.ext";
            logAnalyzer.Analyze2(tooShortFileName);

            var expected = new ErrorInfo()
            {
                Severity = 1000,
                Message = "fake exception"
            };
            mockWebService.Received().Write(expected);
        }
    }
}