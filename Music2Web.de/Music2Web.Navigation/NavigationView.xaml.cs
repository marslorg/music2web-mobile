namespace Music2Web.Navigation;

public partial class NavigationView : ContentPage
{
	private readonly INavigationViewModel viewModel;

    public NavigationView(INavigationViewModel viewModel)
	{
		this.InitializeComponent();

		this.viewModel = viewModel;
        this.BindingContext = this.viewModel;
		
		viewModel.NavigationDrawer = this.navigationDrawer;
    }

    private async void OnNavigationItemSelected(object sender, SelectionChangedEventArgs args)
    {
		await this.viewModel.OnNavigationItemSelectedAsync(sender, args);
    }
}