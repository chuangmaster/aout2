using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class LogAnalyzerUsingFactoryMethod
    {
        public bool IsValidLogFileName(string fileName)
        {
            return this.IsValid(fileName);
        }

        protected virtual bool IsValid(string fileName)
        {
            return new FileExtensionManager().IsValid(fileName);
        }
    }
}
