using Music2Web.Content.ValueObjects;

namespace Music2Web.Content.Ports.Drivers
{
    internal interface IContentSwitcher
    {
        public Music2WebData CurrentMusic2WebData { get; }

        public void AddListener(IContentChangedListener listener);

        public void RemoveListener(IContentChangedListener listener);

        public ValueTask SetMusic2WebAddressAsync(Music2WebAddress music2WebAddress);
    }
}
