using aout2;
using System;
using System.IO;

namespace LogAn
{
    public class LogAnalyzer
    {
        private IExtensionManager _Manager;
        public bool WasLastFileNameValid { get; set; }

        public LogAnalyzer()
        {
            _Manager = ExtensionFactory.Create();
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

            return _Manager.IsValid(fileName) &&　Path.GetFileNameWithoutExtension(fileName).Length > 5;
        }

    }
}