using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public interface IView
    {
        event Action Loaded;
        event Action<string> ErrorOccured;

        void Render(string text);
    }
}
