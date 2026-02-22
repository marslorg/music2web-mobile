using Music2Web.Content.Ports.Driven;
using Music2Web.Content.Ports.Drivers;
using Music2Web.Content.ValueObjects;
using System.Collections.Immutable;

namespace Music2Web.Content.Core
{
    internal class ContentSwitcher : IContentSwitcher
    {
        private readonly List<IContentChangedListener> listeners = [];
        private readonly ISymmetricMessageSignerAdapter symmetricMessageSignerAdapter;

        public ContentSwitcher(ISymmetricMessageSignerAdapter symmetricMessageSignerAdapter)
        {
            this.symmetricMessageSignerAdapter = symmetricMessageSignerAdapter;

            var address = new Music2WebAddress(null);

            this.CurrentMusic2WebData = new Music2WebData
            {
                Address = address,
                UserAgent = new Music2WebUserAgent(
                    this.symmetricMessageSignerAdapter.UserAgentUserName,
                    this.symmetricMessageSignerAdapter.ConstructSignature(HttpMethod.Get, address)),
            };
        }

        public Music2WebData CurrentMusic2WebData { get; private set; }

        public void AddListener(IContentChangedListener listener)
        {
            lock (this.listeners)
            {
                this.listeners.Add(listener);
            }
        }

        public void RemoveListener(IContentChangedListener listener)
        {
            lock (this.listeners)
            {
                this.listeners.Remove(listener);
            }
        }

        public async ValueTask SetMusic2WebAddressAsync(Music2WebAddress music2WebAddress)
        {
            lock(this.CurrentMusic2WebData)
            {
                this.CurrentMusic2WebData = new Music2WebData
                {
                    Address = music2WebAddress,
                    UserAgent = new Music2WebUserAgent(
                        this.symmetricMessageSignerAdapter.UserAgentUserName,
                        this.symmetricMessageSignerAdapter.ConstructSignature(HttpMethod.Get, music2WebAddress)),
                };
            }

            ImmutableList<IContentChangedListener> currentListeners;
            lock (this.listeners)
            {
                currentListeners = this.listeners.ToImmutableList();
            }

            foreach (var listener in currentListeners)
            {
                await listener.OnWebViewChangedAsync(CurrentMusic2WebData);
            }
        }
    }
}
