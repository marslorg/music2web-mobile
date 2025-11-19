using Music2Web.HttpService.Ports.Driven;
using Music2Web.HttpService.ValueObjects;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace Music2Web.HttpService.Adapters.Driven.Implementation
{
    internal class HttpClientAdapter : IHttpClientAdapter
    {
        public async ValueTask<HttpResponseContent> GetAsync(Uri uri, UserName? userName, Password? password)
        {
            var httpClient = new HttpClient();
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            if (userName != null && password != null)
            {
                var secret = ComputeHmacSha512(
                    $"GET{uri.Host}{uri.PathAndQuery}{uri.Fragment}",
                    password.Value);
                var authenticationString = $"{userName.Value}:{secret}";
                var base64EncodedAuthenticationString = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(authenticationString));
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
            }

            var responseMessage = await httpClient.SendAsync(requestMessage);

            return new HttpResponseContent(await responseMessage.Content.ReadAsStreamAsync());
        }

        private string ComputeHmacSha512(string message, string key)
        {
            var hash = new StringBuilder(); ;
            byte[] secretkeyBytes = Encoding.UTF8.GetBytes(key);
            byte[] inputBytes = Encoding.UTF8.GetBytes(message);
            using (var hmac = new HMACSHA512(secretkeyBytes))
            {
                byte[] hashValue = hmac.ComputeHash(inputBytes);
                foreach (var theByte in hashValue)
                {
                    hash.Append(theByte.ToString("x2"));
                }
            }

            return hash.ToString();
        }
    }
}
