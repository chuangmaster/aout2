using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aout2
{
    public class Presenter
    {
        private IView _View;

        public Presenter(IView view)
        {
            _View = view;
            this._View.Loaded += OnLoaded;
        }

        private void OnLoaded()
        {
            _View.Render("Hello World");
        }
    }
}
