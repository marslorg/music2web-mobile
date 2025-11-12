namespace Music2Web.Navigation;

public partial class NavigationView : ContentPage
{
	public NavigationView(INavigationViewModel viewModel)
	{
		this.InitializeComponent();

		this.BindingContext = viewModel;
		
		viewModel.NavigationDrawer = this.navigationDrawer;
    }
}