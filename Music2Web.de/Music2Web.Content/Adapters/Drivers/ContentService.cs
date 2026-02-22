using Music2Web.Content.Ports.Drivers;
using Music2Web.Content.ValueObjects;

namespace Music2Web.Content.Adapters.Drivers
{
    internal class ContentService(IContentSwitcher contentSwitcher) : IContentService
    {
        public ValueTask SetContentAsync(Music2WebAddress music2WebAddress)
        {
            return contentSwitcher.SetMusic2WebAddressAsync(music2WebAddress);
        }
    }
}
