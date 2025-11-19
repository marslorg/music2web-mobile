using Music2Web.HttpService.Adapters.Driven.Implementation;
using Music2Web.HttpService.Adapters.Drivers;
using Music2Web.HttpService.Core;
using Music2Web.HttpService.Ports.Driven;
using Music2Web.HttpService.Ports.Drivers;

namespace Music2Web.HttpService
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureHttpService(this MauiAppBuilder builder)
        {
            builder.Services
                .AddSingleton<IHttpJsonService, HttpJsonService>()
                .AddSingleton<IHttpJsonProvider, HttpJsonProvider>()
                .AddSingleton<ISecretProvider, SecretProvider>()
                .AddSingleton<IHttpClientAdapter, HttpClientAdapter>();

            return builder;
        }
    }
}
