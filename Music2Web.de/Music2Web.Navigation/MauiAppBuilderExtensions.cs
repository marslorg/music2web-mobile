using Music2Web.Navigation.Adapters.Driven.Implementation;
using Music2Web.Navigation.Adapters.Drivers;
using Music2Web.Navigation.Core;
using Music2Web.Navigation.Ports.Driven;
using Music2Web.Navigation.Ports.Drivers;

namespace Music2Web.Navigation
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureNavigation(this MauiAppBuilder builder)
        {
            builder.Services
                .AddSingleton<IContentServiceAdapter, ContentServiceAdapter>()
                .AddSingleton<IHttpServiceAdapter, HttpServiceAdapter>()
                .AddSingleton<INavigationViewModelFactory, NavigationViewModelFactory>()
                .AddSingleton<INavigationProvider, NavigationProvider>();

            return builder;
        }
    }
}
