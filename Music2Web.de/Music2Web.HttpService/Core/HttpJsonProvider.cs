using Music2Web.HttpService.Ports.Driven;
using Music2Web.HttpService.Ports.Drivers;
using Music2Web.HttpService.ValueObjects;
using System.Text.Json;

namespace Music2Web.HttpService.Core
{
    internal class HttpJsonProvider(IHttpClientAdapter httpClientAdapter) : IHttpJsonProvider
    {
        public async ValueTask<T> GetJsonResponseAsync<T>(Uri uri) where T : class
        {
            return JsonSerializer.Deserialize<T>(await httpClientAdapter.GetAsync(uri, null, null).ConfigureAwait(false));
        }

        public async ValueTask<T> GetJsonResponseAsync<T>(Uri uri, UserName userName, Password password) where T : class
        {
            return JsonSerializer.Deserialize<T>(await httpClientAdapter.GetAsync(uri, userName, password).ConfigureAwait(false));
        }
    }
}
