using aout2;
using LogAn;
using NSubstitute;
using NUnit.Framework;
namespace UnitTestProject1
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortName_CallLogger()
        {
            //FakeLogger logger = new FakeLogger();
            ILogger logger = Substitute.For<ILogger>();

            LogAn.LogAnalyzer analyzer = new LogAn.LogAnalyzer(logger);
            analyzer.MinNameLength = 6;
            analyzer.Analyze("a.txt");
            logger.Received().LogError("too short");

        }
    }
}