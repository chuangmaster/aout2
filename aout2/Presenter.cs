using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class Presenter
    {
        private IView _View;
        private ILogger _Logger;

        public Presenter(IView view, ILogger logger)
        {
            _View = view;
            this._View.Loaded += OnLoaded;
            this._View.ErrorOccured += OnError;

            this._Logger = logger;
        }

        private void OnLoaded()
        {
            _View.Render("Hello World");
        }
        private void OnError(string message)
        {
            _Logger.LogError(message);
        }
    }
}
