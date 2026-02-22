using CommunityToolkit.Mvvm.ComponentModel;
using Music2Web.Content.Ports.Drivers;
using Music2Web.Content.ValueObjects;

namespace Music2Web.Content.Adapters.Drivers
{
    internal partial class Music2WebViewModel : ObservableObject, IContentChangedListener, IMusic2WebViewModel
    {
        private readonly IContentSwitcher contentSwitcher;

        [ObservableProperty]
        private Music2WebData webData;

        public Music2WebViewModel(
            IContentSwitcher contentSwitcher)
        {
            this.contentSwitcher = contentSwitcher;

            this.WebData = this.contentSwitcher.CurrentMusic2WebData;

            this.contentSwitcher.AddListener(this);
        }

        public ValueTask OnWebViewChangedAsync(Music2WebData music2WebData)
        {
            this.WebData = music2WebData;

            return ValueTask.CompletedTask;
        }

        public void Dispose()
        {
            this.contentSwitcher.RemoveListener(this);
        }
    }
}
