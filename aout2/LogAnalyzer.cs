using aout2;
using aout2.Services.Interfaces;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer
    {
        private ILogger _Logger;
        public int MinNameLength = 5;
        public LogAnalyzer(ILogger logger)
        {
            _Logger = logger;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < MinNameLength)
            {
                /*_WebService.LogError("Filename is too short:" + fileName);*/
                _Logger.LogError("too short");
            }
        }

    }
}