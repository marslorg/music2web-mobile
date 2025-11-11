namespace Music2Web.Navigation;

public partial class NavigationView : ContentPage
{
	public NavigationView()
	{
		InitializeComponent();
	}

	private void hamburgerButton_Clicked(object sender, EventArgs e)
	{
		navigationDrawer.ToggleDrawer();
    }
}