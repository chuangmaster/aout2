using aout2.Parser;
using NSubstitute.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.StringParserTests
{
    [TestFixture]
    public abstract class FillInTheBlanksStringParserTests
    {
        protected abstract IStringParser GetParser(string input);
        protected abstract string HeaderVersion_SingleDigit { get; }
        protected abstract string HeaderVersion_WithMinorVersionDigit { get; }
        protected abstract string HeaderVersion_WithRevision { get; }

        public const string EXPECTED_SINGLEDIGIT = "1";
        public const string EXPECTED_WITHMINORVERSIONDIGIT = "1.1";
        public const string EXPECTED_WITHREVISION = "1.1.1";

        [Test]
        public void TestGetTextVersionFromHeader_SingleDigit_Found()
        {
            string input = HeaderVersion_SingleDigit;
            IStringParser parser = GetParser(input);
            string act = parser.GetTextVersionFromHeader();
            Assert.AreEqual(EXPECTED_SINGLEDIGIT, act);
        }
        [Test]
        public void TestGetTextVersionFromHeader_WithMinorVersionDigit_Found()
        {
            string input = HeaderVersion_WithMinorVersionDigit;
            IStringParser parser = GetParser(input);
            string act = parser.GetTextVersionFromHeader();
            Assert.AreEqual(EXPECTED_WITHMINORVERSIONDIGIT, act);
        }

        [Test]
        public void TestGetTextVersionFromHeader_WithRevision_Found()
        {
            string input = HeaderVersion_WithRevision;
            IStringParser parser = GetParser(input);
            string act = parser.GetTextVersionFromHeader();
            Assert.AreEqual(EXPECTED_WITHREVISION, act);
        }
    }
}
