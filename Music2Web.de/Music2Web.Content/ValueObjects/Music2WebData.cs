using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music2Web.Content.ValueObjects
{
    public class Music2WebData
    {
        public required Music2WebAddress Address { get; init; }

        public required Music2WebUserAgent UserAgent { get; init; }
    }
}
