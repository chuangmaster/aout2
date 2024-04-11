using aout2;
using aout2.Services.Interfaces;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer2
    {
        public IWebService _WebService { get; set; }
        public ILogger _Logger { get; set; }

        public LogAnalyzer2(IWebService webService, ILogger logger)
        {
            _WebService = webService;
            _Logger = logger;
        }

        public int MinNameLength { get; set; }

        public void Analyze(string fileName)
        {
            if (fileName.Length < MinNameLength)
            {
                try
                {
                    _Logger.LogError($"Filename too short: {fileName}");
                }
                catch (Exception e)
                {
                    _WebService.Write("Error From Logger" + e.Message);
                }
            }
        }

        public void Analyze2(string fileName)
        {
            if (fileName.Length < MinNameLength)
            {
                try
                {
                    _Logger.LogError($"Filename too short: {fileName}");
                }
                catch (Exception e)
                {
                    _WebService.Write(new ErrorInfo()
                    {
                        Severity = 1000,
                        Message = e.Message
                    });
                }
            }
        }

    }
}