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

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationView(this.navigationViewModelFactory.CreateViewModel()));
        }
    }
}