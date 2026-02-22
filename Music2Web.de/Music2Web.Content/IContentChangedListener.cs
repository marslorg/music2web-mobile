using Music2Web.Content.ValueObjects;

namespace Music2Web.Content
{
    public interface IContentChangedListener
    {
        public ValueTask OnWebViewChangedAsync(Music2WebData music2WebData);
    }
}
