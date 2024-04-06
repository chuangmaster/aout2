using aout2;
using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        IExtensionManager _Manager;
        public bool WasLastFileNameValid { get; set; }

        public LogAnalyzer(IExtensionManager mgr)
        {
            _Manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            #region old
            //WasLastFileNameValid = false;

            //if (string.IsNullOrEmpty(fileName))
            //{
            //    throw new ArgumentException("filename has to be provided");
            //}
            //if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
            //{
            //    return false;
            //}

            //WasLastFileNameValid = true;
            #endregion

            return _Manager.IsValid(fileName);
        }

    }
}