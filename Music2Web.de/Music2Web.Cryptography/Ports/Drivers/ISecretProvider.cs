using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.Cryptography.Ports.Drivers
{
    internal interface ISecretProvider
    {
        public UserName UserName { get; }
        public Password Password { get; }
    }
}
