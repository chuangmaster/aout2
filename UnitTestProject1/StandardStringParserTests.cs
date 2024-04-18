﻿using aout2.Parser;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class StandardStringParserTests
    {
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