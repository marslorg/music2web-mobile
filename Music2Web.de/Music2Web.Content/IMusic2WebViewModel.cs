using Music2Web.Content.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music2Web.Content
{
    public interface IMusic2WebViewModel
    {
        public Music2WebAddress Address { get; }
        public Music2WebUserAgent UserAgent { get; }
    }
}
