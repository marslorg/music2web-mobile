using Music2Web.Content.Ports.Driven;
using Music2Web.Content.ValueObjects;
using Music2Web.Cryptography;
using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.Content.Adapters.Driven.Implementation
{
    internal class SymmetricMessageSignerAdapter(ISecretService secretService, ISymmetricMessageSigner symmetricMessageSigner) : ISymmetricMessageSignerAdapter
    {
        public Music2WebUserAgentUserName UserAgentUserName => new Music2WebUserAgentUserName(secretService.UserName.Value);

        public Music2WebUserAgentSignature ConstructSignature(HttpMethod httpMethod, Music2WebAddress address)
        {
            return new Music2WebUserAgentSignature(
                symmetricMessageSigner
                .ConstructHmacSha512Signature(
                    new Message($"{httpMethod.Method}{address.Host}{address.Path}"),
                    new Key(secretService.Password.Value))
                .Value);
        }
    }
}
