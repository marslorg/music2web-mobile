using Music2Web.Cryptography.Ports.Drivers;
using Music2Web.Cryptography.ValueObjects;
using System.Security.Cryptography;
using System.Text;

namespace Music2Web.Cryptography.Adapters.Drivers
{
    internal class SymmetricMessageSigner(IHashProvider hashProvider) : ISymmetricMessageSigner
    {
        public Signature ConstructHmacSha512Signature(Message message, Key key)
        {
            return hashProvider.ConstructHmacSha512Signature(message, key);
        }
    }
}
