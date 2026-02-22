using Music2Web.Content;
using Music2Web.Content.ValueObjects;
using Music2Web.Navigation.DataModels;
using Music2Web.Navigation.Ports.Driven;

namespace Music2Web.Navigation.Adapters.Driven.Implementation
{
    internal class ContentServiceAdapter(IContentService contentService) : IContentServiceAdapter
    {
        public ValueTask SetContentAsync(NavigationItem navigationItem)
        {
            return contentService.SetContentAsync(new Music2WebAddress(navigationItem.NavigationItemTarget.Value));
        }
    }
}
