using Music2Web.Navigation.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music2Web.Navigation.Ports.Driven
{
    internal interface IContentServiceAdapter
    {
        public ValueTask SetContentAsync(NavigationItem navigationItem);
    }
}
