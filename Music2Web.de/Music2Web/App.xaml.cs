using Music2Web.Navigation;

namespace Music2Web
{
    public partial class App : Application
    {
        private readonly INavigationViewModelFactory navigationViewModelFactory;

        public App(INavigationViewModelFactory navigationViewModelFactory)
        {
            this.navigationViewModelFactory = navigationViewModelFactory;

            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState) => new(new NavigationView(this.navigationViewModelFactory.CreateViewModelAsync().Result));
    }
}