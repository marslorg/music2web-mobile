using Music2Web.Content.Adapters.Drivers;

namespace Music2Web.Content;

public partial class Music2WebView : WebView
{
	private readonly IMusic2WebViewModel viewModel;

	public Music2WebView()
	{
		InitializeComponent();

		this.viewModel = Application.Current.Handler.MauiContext.Services.GetService<IMusic2WebViewModelFactory>().CreateViewModel();
        this.BindingContext = this.viewModel;
    }
}