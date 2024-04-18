using aout2.Parser;
using NUnit.Framework;

namespace UnitTestProject1.StringParserTests
{
    [TestFixture]
    public class StandardStringParserTests
    {
        // 用工廠方法來取得SUT
        private StandardStringParser GetParser(string input)
        {
            return new StandardStringParser(input);
        }

        [Test]
        public void GetTextVersionFromHeader_SingleDigit_Found()
        {
            string input = "header;version=1;\n";
            StandardStringParser parser = GetParser(input);
            string versionFromHeader = parser.GetTextVersionFromHeader();
            Assert.AreEqual("1", versionFromHeader);  
        }

        [Test]
        public void GetTextVersionFromHeader_WithMinorVersionDigit_Found()
        {
            string input = "header;version=1.1;\n";
            StandardStringParser parser = GetParser(input);
            string versionFromHeader = parser.GetTextVersionFromHeader();
            Assert.AreEqual("1.1", versionFromHeader);
        }

        [Test]
        public void GetTextVersionFromHeader_WithRevision_Found()
        {
            string input = "header;version=1.1.1;\n";
            StandardStringParser parser = GetParser(input);
            string versionFromHeader = parser.GetTextVersionFromHeader();
            Assert.AreEqual("1.1.1", versionFromHeader);
        }
    }
}
