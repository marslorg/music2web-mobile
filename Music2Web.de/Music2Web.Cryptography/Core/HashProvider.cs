using Music2Web.Cryptography.Ports.Drivers;
using Music2Web.Cryptography.ValueObjects;
using System.Security.Cryptography;
using System.Text;

namespace Music2Web.Cryptography.Core
{
    internal class HashProvider : IHashProvider
    {
        public Signature ConstructHmacSha512Signature(Message message, Key key)
        {
            var hash = new StringBuilder(); ;
            byte[] secretkeyBytes = Encoding.UTF8.GetBytes(key.Value);
            byte[] inputBytes = Encoding.UTF8.GetBytes(message.Value);
            using (var hmac = new HMACSHA512(secretkeyBytes))
            {
                byte[] hashValue = hmac.ComputeHash(inputBytes);
                foreach (var theByte in hashValue)
                {
                    hash.Append(theByte.ToString("x2"));
                }
            }

            return new Signature(hash.ToString());
        }
    }
}
