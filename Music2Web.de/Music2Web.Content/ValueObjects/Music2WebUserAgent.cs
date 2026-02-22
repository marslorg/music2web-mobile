using Music2Web.Cryptography.ValueObjects;
using System.Runtime.CompilerServices;

namespace Music2Web.Content.ValueObjects
{
    public record Music2WebUserAgent(Music2WebUserAgentUserName userName, Music2WebUserAgentSignature signature)
    {
        public string Value => $"music2webapp;{userName.Value};{signature.Value}";
    }
}
