using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.Cryptography
{
    public interface ISecretService
    {
        public UserName UserName { get; }
        public Password Password { get; }
    }
}
