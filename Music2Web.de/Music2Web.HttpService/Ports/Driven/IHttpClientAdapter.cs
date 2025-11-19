using Music2Web.HttpService.ValueObjects;

namespace Music2Web.HttpService.Ports.Driven
{
    internal interface IHttpClientAdapter
    {
        public ValueTask<HttpResponseContent> GetAsync(Uri uri, UserName? userName, Password? password);
    }
}
