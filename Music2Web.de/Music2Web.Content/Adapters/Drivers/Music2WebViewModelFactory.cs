
namespace Music2Web.Content.Adapters.Drivers
{
    internal class Music2WebViewModelFactory : IMusic2WebViewModelFactory
    {
        public IMusic2WebViewModel CreateViewModel()
        {
            return new Music2WebViewModel();
        }
    }
}
