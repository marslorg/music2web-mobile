using Music2Web.HttpService;
using Music2Web.HttpService.ValueObjects;
using Music2Web.Navigation.Ports.Driven;

namespace Music2Web.Navigation.Adapters.Driven.Implementation
{
    internal class HttpServiceAdapter(IHttpJsonService httpJsonService) : IHttpServiceAdapter
    {
        public async ValueTask<T> GetJsonResponseAsync<T>(Uri uri) where T : class => await httpJsonService.GetJsonResponseAsync<T>(uri, new WithSecretState(true)).ConfigureAwait(false);
    }
}
