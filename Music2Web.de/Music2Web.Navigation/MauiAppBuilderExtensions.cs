using Music2Web.Navigation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
