using aout2;
using NUnit.Framework;
namespace UnitTestProject1
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void OverrideTest() { 

            TestableLogAnalyzer testableLogAnalyzer= new TestableLogAnalyzer();
            testableLogAnalyzer.IsSupported = true;

            bool result = testableLogAnalyzer.IsValidLogFileName("fileName.ext");
            Assert.IsTrue(result);
            
        }
    }
}