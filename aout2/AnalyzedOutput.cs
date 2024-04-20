using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class AnalyzedOutput
    {
        private List<LineInfo> lines;
        public AnalyzedOutput()
        {
            lines = new List<LineInfo>();
        }
        public void AddLine(params string[] inputs) {
            LineInfo line = new LineInfo();
            foreach (string input in inputs) {
                line.Add(input);
            }
            lines.Add(line);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var line in lines)
            {
                sb.Append(line);
            }
            return sb.ToString();
        }
    }
}
