using aout2.Parser;
using NUnit.Framework;

namespace UnitTestProject1.StringParserTests
{
    [TestFixture]
    public class StandardStringParserTests : FillInTheBlanksStringParserTests
    {
        protected override string HeaderVersion_SingleDigit => $"header;version={EXPECTED_SINGLEDIGIT};";

        protected override string HeaderVersion_WithMinorVersionDigit => $"header;version={EXPECTED_WITHMINORVERSIONDIGIT};";

        protected override string HeaderVersion_WithRevision => $"header;version={EXPECTED_WITHREVISION};";

        protected override IStringParser GetParser(string input)
        {
            return new StandardStringParser(input);
        }

        // 因為繼承 FillInTheBlanksStringParserTests 所以也有原本 FillInTheBlanksStringParserTests 的測試
        // 延伸類別用於定義預期的內容，以及工廠模式所提供需要當作SUT的內容
    }
}
