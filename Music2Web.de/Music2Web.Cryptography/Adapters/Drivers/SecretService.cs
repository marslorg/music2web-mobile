using Music2Web.Cryptography.Ports.Drivers;
using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.Cryptography.Core
{
    internal class SecretService(ISecretProvider secretProvider) : ISecretService
    {
        public UserName UserName => secretProvider.UserName;

        public Password Password => secretProvider.Password;
    }
}
