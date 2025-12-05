using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.HttpService.Ports.Driven
{
    internal interface IHttpClientAdapter
    {
        public ValueTask<string> GetAsync(Uri uri, UserName? userName, Password? password);
    }
}
