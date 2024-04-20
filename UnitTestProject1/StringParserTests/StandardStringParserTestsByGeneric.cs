using aout2.Parser;
using NUnit.Framework;

namespace UnitTestProject1.StringParserTests
{
    [TestFixture]
    public class StandardStringParserTestsByGeneric : GenericParserTests<StandardStringParser>
    {
        //protected override string HeaderVersion_SingleDigit => $"header;version={EXPECTED_SINGLEDIGIT};";

        //protected override string HeaderVersion_WithMinorVersionDigit => $"header;version={EXPECTED_WITHMINORVERSIONDIGIT};";

        //protected override string HeaderVersion_WithRevision => $"header;version={EXPECTED_WITHREVISION};";

        protected override string GetInputHeaderSingleDigit()
        {
            return $"header;version=1";
        }
    }
}
