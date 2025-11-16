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

    private void OnNavigationItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
		this.viewModel.OnNavigationItemSelected(sender, args);
    }
}