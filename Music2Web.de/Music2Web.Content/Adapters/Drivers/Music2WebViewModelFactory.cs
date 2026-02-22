
using Music2Web.Content.Ports.Drivers;
using Music2Web.Content.ValueObjects;

namespace Music2Web.Content.Adapters.Drivers
{
    internal class Music2WebViewModelFactory(
        IContentSwitcher contentSwitcher) : IMusic2WebViewModelFactory
    {
        public IMusic2WebViewModel CreateViewModel()
        {
            return new Music2WebViewModel(contentSwitcher);
        }
    }
}
