using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {

        public bool IsSupported { get; set; }
        protected override bool IsValid(string fileName)
        {
            return IsSupported;
        }

    }
}
