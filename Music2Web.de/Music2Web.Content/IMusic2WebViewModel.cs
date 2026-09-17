using Music2Web.Content.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music2Web.Content
{
    public interface IMusic2WebViewModel : IDisposable
    {
        public Music2WebData WebData { get; }

        public bool IsLoading { get; set; }

        public ValueTask HandleWebViewNavigationAsync(Music2WebAddress music2WebAddress);
    }
}
