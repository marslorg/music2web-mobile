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
                .AddSingleton<INavigationViewModelFactory, NavigationViewModelFactory>()
                .AddSingleton<INavigationDataProvider, NavigationDataProvider>()
                .AddSingleton<IHttpServiceAdapter, HttpServiceAdapter>();

            return builder;
        }
    }
}
