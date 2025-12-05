using Music2Web.Cryptography.ValueObjects;

namespace Music2Web.HttpService.Ports.Drivers
{
    internal interface IHttpJsonProvider
    {
        public ValueTask<T> GetJsonResponseAsync<T>(Uri uri) where T : class;
        public ValueTask<T> GetJsonResponseAsync<T>(Uri uri, UserName userName, Password password) where T : class;
    }
}
