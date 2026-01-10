using Music2Web.Cryptography;
using Music2Web.Cryptography.ValueObjects;
using Music2Web.HttpService.Ports.Driven;
using System.Net.Http.Headers;
using System.Text;

namespace Music2Web.HttpService.Adapters.Driven.Implementation
{
    internal class HttpClientAdapter(ISymmetricMessageSigner symmetricMessageSigner) : IHttpClientAdapter
    {
        public async ValueTask<string> GetAsync(Uri uri, UserName? userName, Password? password)
        {
            var httpClient = new HttpClient();
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            if (userName != null && password != null)
            {
                var signature = symmetricMessageSigner.ConstructHmacSha512Signature(
                    new Message($"GET{uri.Host}{uri.PathAndQuery}{uri.Fragment}"),
                    new Key(password.Value));
                var authenticationString = $"{userName.Value}:{signature.Value}";
                var base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(authenticationString));
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
            }

            var responseMessage = httpClient.SendAsync(requestMessage).Result;

            return await responseMessage.Content.ReadAsStringAsync();
        }
    }
}
