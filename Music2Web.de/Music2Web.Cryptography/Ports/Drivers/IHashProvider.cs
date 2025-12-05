using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.Cryptography.Ports.Drivers
{
    internal interface IHashProvider
    {
        public Signature ConstructHmacSha512Signature(Message message, Key key);
    }
}
