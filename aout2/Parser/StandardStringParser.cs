using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace aout2.Parser
{
    public class StandardStringParser : BaseStringParser
    {
        public StandardStringParser(string input)
        {
            this.StringToParse = input;
        }
        public override string GetTextVersionFromHeader()
        {
            Regex reg = new Regex(@"version=(\d+\.\d+.\d+)", RegexOptions.IgnoreCase);
            var match = reg.Match(this.StringToParse);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            reg = new Regex(@"version=(\d+\.\d+)", RegexOptions.IgnoreCase);
            match = reg.Match(this.StringToParse);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            reg = new Regex(@"version=(\d+)", RegexOptions.IgnoreCase);
            match = reg.Match(this.StringToParse);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return string.Empty;
            }
        }

        public override string HasCorrectHeader()
        {
            throw new NotImplementedException();
        }
    }
}
