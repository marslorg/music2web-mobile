namespace Music2Web.Navigation.Internal
{
    internal class NavigationViewModelFactory : INavigationViewModelFactory
    {
        public INavigationViewModel CreateViewModel()
        {
            return new NavigationViewModel();
        }
    }
}
