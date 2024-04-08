using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class TestableLogAnalyzer : LogAnalyzerUsingFactoryMethod
    {
        private IExtensionManager _Manager;

        public TestableLogAnalyzer(IExtensionManager manager)
        {
            _Manager = manager;
        }
        protected override IExtensionManager GetManager()
        {
            return _Manager;
        }

    }
}
