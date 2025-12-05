using Music2Web.Content.Adapters.Drivers;

namespace Music2Web.Content
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureContent(this MauiAppBuilder builder)
        {
        builder.Services
            .AddSingleton<IMusic2WebViewModelFactory, Music2WebViewModelFactory>();

            return builder;
        }
    }
}
