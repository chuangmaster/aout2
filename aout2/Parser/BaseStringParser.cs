using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2.Parser
{
    public interface IStringParser
    {
        string GetTextVersionFromHeader();
        string HasCorrectHeader();
    }
    public abstract class BaseStringParser : IStringParser
    {
        public string StringToParse { get; set; }

        protected BaseStringParser()
        {

        }

        public abstract string GetTextVersionFromHeader();
        public abstract string HasCorrectHeader();

    }
}
