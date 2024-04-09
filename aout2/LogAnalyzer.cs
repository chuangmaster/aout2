using aout2;
using aout2.Services.Interfaces;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer
    {
        private FakeLogger FakeLogger;
        public int MinNameLength = 5;
        public LogAnalyzer(FakeLogger logger)
        {
            FakeLogger = logger;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < MinNameLength)
            {
                /*_WebService.LogError("Filename is too short:" + fileName);*/
                FakeLogger.Log("too short");
            }
        }

    }
}