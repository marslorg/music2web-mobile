using Music2Web.Content.Adapters.Drivers;
using Music2Web.Content.ValueObjects;

namespace Music2Web.Content;

public partial class Music2WebView : ContentView
{
    private readonly IMusic2WebViewModel viewModel;

    public Music2WebView()
    {
        InitializeComponent();

        this.viewModel = Application.Current.Handler.MauiContext.Services.GetService<IMusic2WebViewModelFactory>().CreateViewModel();
        this.BindingContext = this.viewModel;
    }

    private async void OnWebViewNavigating(object sender, WebNavigatingEventArgs args)
    {
        this.viewModel.IsLoading = true;

        if (sender is WebView webView)
        {
            await this.viewModel.HandleWebViewNavigationAsync(new Music2WebAddress(args.Url));
        }
    }

    private void OnWebViewNavigated(object sender, WebNavigatedEventArgs args)
    {
        this.viewModel.IsLoading = false;
    }
}