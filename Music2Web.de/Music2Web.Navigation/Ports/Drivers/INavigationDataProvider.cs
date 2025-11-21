using Music2Web.Navigation.DataModels;
using System.Collections.Immutable;

namespace Music2Web.Navigation.Ports.Drivers
{
    internal interface INavigationDataProvider
    {
        public ValueTask<IImmutableList<NavigationItem>> GetNavigationItemsAsync();
    }
}
