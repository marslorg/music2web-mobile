using Music2Web.Content.ValueObjects;

namespace Music2Web.Content
{
    public interface IContentService
    {
        public ValueTask SetContentAsync(Music2WebAddress music2WebAddress);
    }
}
