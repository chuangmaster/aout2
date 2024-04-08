using aout2;
using aout2.Services.Interfaces;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer
    {
        private IWebService _WebService { get; set; }

        public LogAnalyzer(IWebService webService)
        {
            _WebService = webService;
        }

        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
            {
                _WebService.LogError("Filename is too short:" + fileName);
            }
        }

    }
}