namespace Music2Web.Navigation
{
    public interface INavigationViewModelFactory
    {
        public ValueTask<INavigationViewModel> CreateViewModelAsync();
    }
}
