using Music2Web.HttpService.ValueObjects;

namespace Music2Web.HttpService
{
    public interface IHttpJsonService
    {
        public ValueTask<T> GetJsonResponseAsync<T>(Uri uri, WithSecretState withSecretState) where T : class;
    }
}
