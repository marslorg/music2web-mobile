using Music2Web.HttpService.ValueObjects;

namespace Music2Web.HttpService.Ports.Drivers
{
    internal interface IHttpJsonProvider
    {
        public ValueTask<T> GetJsonResponseAsync<T>(Uri uri) where T : class;
        public ValueTask<T> GetJsonResponseAsync<T>(Uri uri, UserName userName, Password password) where T : class;
    }
}
