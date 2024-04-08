using aout2;
using NUnit.Framework;
namespace UnitTestProject1
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void OverrideTest() { 

            FakeExtensionManager stub = new FakeExtensionManager();
            stub.WillBeValid = true;

            TestableLogAnalyzer testableLogAnalyzer= new TestableLogAnalyzer(stub);

            bool result = testableLogAnalyzer.IsValidLogFile("fileName.ext");
            Assert.IsTrue(result);
            
        }
    }
}