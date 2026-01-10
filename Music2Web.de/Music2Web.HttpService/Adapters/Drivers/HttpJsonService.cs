
using Music2Web.Cryptography;
using Music2Web.HttpService.Ports.Drivers;
using Music2Web.HttpService.ValueObjects;

namespace Music2Web.HttpService.Adapters.Drivers
{
    internal class HttpJsonService(
        IHttpJsonProvider httpJsonProvider,
        ISecretService secretService) : IHttpJsonService
    {
        public async ValueTask<T> GetJsonResponseAsync<T>(Uri uri, WithSecretState withSecretState) where T : class
        {
            if (withSecretState.Value)
            {
                return await httpJsonProvider.GetJsonResponseAsync<T>(uri, secretService.UserName, secretService.Password);
            }

            return await httpJsonProvider.GetJsonResponseAsync<T>(uri);
        }
    }
}
