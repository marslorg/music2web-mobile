using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.Cryptography
{
    public interface ISymmetricMessageSigner
    {
        public Signature ConstructHmacSha512Signature(Message message, Key key);
    }
}
