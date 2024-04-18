using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.StringParserTests
{
    public abstract class TemplateStringParserTests
    {
        public abstract void TestGetTextVersionFromHeader_SingleDigit_Found();
        public abstract void TestGetTextVersionFromHeader_WithMinorVersionDigit_Found();
        public abstract void TestGetTextVersionFromHeader_WithRevision_Found();

    }
}
