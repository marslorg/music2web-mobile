using Music2Web.Navigation.DataModels;
using Music2Web.Navigation.Ports.Driven;
using Music2Web.Navigation.Ports.Drivers;
using Music2Web.Navigation.ValueObjects;
using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Music2Web.Navigation.Core
{
    internal class NavigationDataProvider(IHttpServiceAdapter httpServiceAdapter) : INavigationDataProvider
    {
        public async ValueTask<IImmutableList<NavigationItem>> GetNavigationItemsAsync()
        {
            var navigationJsonModel = await httpServiceAdapter.GetJsonResponseAsync<IImmutableList<NavigationItemJsonModel>>(new Uri("https://www.music2web.de/api/1/menu/read")).ConfigureAwait(false);

            var navigationItemList = new List<NavigationItem>();

            foreach (var navigationItem in navigationJsonModel)
            {
                if (navigationItem.NavigationItemTarget != null)
                {
                    navigationItemList.Add(new NavigationItem
                    {
                        NavigationItemId = new NavigationItemId(navigationItem.NavigationItemId),
                        NavigationItemName = new NavigationItemName(navigationItem.NavigationItemName),
                        NavigationItemTarget = new NavigationItemTarget(navigationItem.NavigationItemTarget),
                    });
                }

                if (navigationItem.NavigationItems != null && navigationItem.NavigationItems.Count > 0)
                {
                    foreach (var linkItem  in navigationItem.NavigationItems)
                    {
                        navigationItemList.Add(new NavigationItem
                        {
                            NavigationItemId = new NavigationItemId(linkItem.NavigationItemId),
                            NavigationItemName = new NavigationItemName(linkItem.NavigationItemName),
                            NavigationItemTarget = new NavigationItemTarget(linkItem.NavigationItemTarget),
                        });
                    }
                }
            }

            return navigationItemList.ToImmutableList<NavigationItem>();
        }

        private class NavigationItemJsonModel
        {
            [JsonPropertyName("id")]
            [JsonRequired]
            public required int NavigationItemId { get; init; }

            [JsonPropertyName("name")]
            [JsonRequired]
            public required string NavigationItemName { get; init; }

            [JsonPropertyName("target")]
            public string? NavigationItemTarget { get; init; }

            [JsonPropertyName("links")]
            public IImmutableList<NavigationItemJsonModel>? NavigationItems { get; init; }
        }
    }
}
