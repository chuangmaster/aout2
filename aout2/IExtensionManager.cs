using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }

    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }

    public class ExtensionFactory
    {
        private static IExtensionManager _ExtensionManager;
        public static IExtensionManager Create()
        {
            if(_ExtensionManager == null)
            {
                return _ExtensionManager;
            }
            return new FileExtensionManager();
        }

        public static void SetManager(IExtensionManager manager)
        {
            _ExtensionManager = manager; 
        }
    }
}
