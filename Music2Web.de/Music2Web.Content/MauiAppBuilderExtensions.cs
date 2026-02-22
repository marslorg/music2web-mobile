using Music2Web.Content.Adapters.Driven.Implementation;
using Music2Web.Content.Adapters.Drivers;
using Music2Web.Content.Core;
using Music2Web.Content.Ports.Driven;
using Music2Web.Content.Ports.Drivers;

namespace Music2Web.Content
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureContent(this MauiAppBuilder builder)
        {
        builder.Services
            .AddSingleton<IContentService, ContentService>()
            .AddSingleton<IContentSwitcher, ContentSwitcher>()
            .AddSingleton<IMusic2WebViewModelFactory, Music2WebViewModelFactory>()
            .AddSingleton<ISymmetricMessageSignerAdapter, SymmetricMessageSignerAdapter>();

            return builder;
        }
    }
}
