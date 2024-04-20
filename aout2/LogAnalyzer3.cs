using aout2;
using aout2.Services.Interfaces;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer3
    {
        public AnalyzedOutput Analyze(string input)
        {
            char[] chars = new char[] { '\t' };
            var temp = input.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            var result = new AnalyzedOutput();
            result.AddLine(temp);
            return result;
        }
    }
}