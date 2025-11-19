using Music2Web.Navigation.DataModels;
using Music2Web.Navigation.ValueObjects;
using System.Collections.Immutable;

namespace Music2Web.Navigation.Adapters.Drivers
{
    internal class NavigationViewModelFactory : INavigationViewModelFactory
    {
        public INavigationViewModel CreateViewModel()
        {
            var navigation = new List<NavigationItem>
            {
                new NavigationItem
                {
                    NavigationItemId = new NavigationItemId(178),
                    NavigationItemName = new NavigationItemName("Home"),
                    NavigationItemTarget = new NavigationItemTarget(new Uri("https://www.music2web.de/home-178")),
                },
                new NavigationItem
                {
                    NavigationItemId = new NavigationItemId(237),
                    NavigationItemName = new NavigationItemName("Aktuelles"),
                    NavigationItemTarget = new NavigationItemTarget(new Uri("https://www.music2web.de/aktuelles-237")),
                },
            };

            return new NavigationViewModel()
            {
                Navigation = navigation.ToImmutableList(),
            };
        }
    }
}
