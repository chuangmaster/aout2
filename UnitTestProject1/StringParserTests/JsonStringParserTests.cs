using aout2.Parser;
using NUnit.Framework;


namespace UnitTestProject1.StringParserTests
{
    [TestFixture]
    public class JsonStringParserTests : FillInTheBlanksStringParserTests
    {
        protected override string HeaderVersion_SingleDigit => @"{ 
                                                                    ""version"" : ""1"" 
                                                                  }";

        protected override string HeaderVersion_WithMinorVersionDigit => throw new System.NotImplementedException();

        protected override string HeaderVersion_WithRevision => throw new System.NotImplementedException();

        protected override IStringParser GetParser(string input)
        {
            return new JsonStringParser(input);
        }
    }
}
