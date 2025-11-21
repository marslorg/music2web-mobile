using Music2Web.Navigation.DataModels;
using Music2Web.Navigation.Ports.Drivers;
using Music2Web.Navigation.ValueObjects;
using System.Collections.Immutable;

namespace Music2Web.Navigation.Adapters.Drivers
{
    internal class NavigationViewModelFactory(INavigationDataProvider navigationDataProvider) : INavigationViewModelFactory
    {
        public async ValueTask<INavigationViewModel> CreateViewModelAsync()
        {
            return new NavigationViewModel()
            {
                Navigation = await navigationDataProvider.GetNavigationItemsAsync().ConfigureAwait(false),
            };
        }
    }
}
