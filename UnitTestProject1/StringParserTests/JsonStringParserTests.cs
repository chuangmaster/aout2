using aout2.Parser;
using NUnit.Framework;


namespace UnitTestProject1.StringParserTests
{
    [TestFixture]
    public class JsonStringParserTests : TemplateStringParserTests
    {
        protected IStringParser GetParser(string input)
        {
            return new JsonStringParser(input);
        }
        [Test]
        public override void TestGetTextVersionFromHeader_SingleDigit_Found()
        {
            var input = @"{ 
                            ""version"" : ""1"" 
                          }";
            IStringParser parser = GetParser(input);
            var act = parser.GetTextVersionFromHeader();
            Assert.AreEqual("1", act);
        }

        public override void TestGetTextVersionFromHeader_WithMinorVersionDigit_Found()
        {
            throw new System.NotImplementedException();
        }

        public override void TestGetTextVersionFromHeader_WithRevision_Found()
        {
            throw new System.NotImplementedException();
        }


    }
}
