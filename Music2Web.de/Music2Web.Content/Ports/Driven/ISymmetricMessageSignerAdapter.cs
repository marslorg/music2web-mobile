using Music2Web.Content.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music2Web.Content.Ports.Driven
{
    internal interface ISymmetricMessageSignerAdapter
    {
        public Music2WebUserAgentUserName UserAgentUserName { get; }

        public Music2WebUserAgentSignature ConstructSignature(HttpMethod httpMethod, Music2WebAddress address);
    }
}
