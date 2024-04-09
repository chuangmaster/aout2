using aout2;
using LogAn;
using NUnit.Framework;
namespace UnitTestProject1
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void Analyze_CallWithMinName_LogError()
        {

            FakeLogger logger = new FakeLogger();
            LogAnalyzer analyzer = new LogAnalyzer(logger);
            analyzer.MinNameLength = 6;
            analyzer.Analyze("a.txt");
            StringAssert.Contains("too short", logger.LastError);

        }
    }
}