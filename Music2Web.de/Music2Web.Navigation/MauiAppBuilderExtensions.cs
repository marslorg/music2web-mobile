using Music2Web.Navigation.Adapters.Drivers;

namespace Music2Web.Navigation
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureNavigation(this MauiAppBuilder builder)
        {
            builder.Services
                .AddSingleton<INavigationViewModelFactory, NavigationViewModelFactory>();

            return builder;
        }
    }
}
