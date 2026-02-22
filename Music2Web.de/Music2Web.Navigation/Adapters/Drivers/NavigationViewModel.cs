using Music2Web.Navigation.DataModels;
using Music2Web.Navigation.Ports.Drivers;
using Music2Web.Navigation.ValueObjects;
using Syncfusion.Maui.Toolkit.NavigationDrawer;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Windows.Input;

namespace Music2Web.Navigation.Adapters.Drivers
{
    internal class NavigationViewModel : INavigationViewModel
    {
        private readonly INavigationProvider navigationProvider;

        private NavigationItem? selectedNavigationItem;

        public NavigationViewModel(
            INavigationProvider navigationProvider)
        {
            this.navigationProvider = navigationProvider;

            ToggleDrawerCommand = new Command(ToggleDrawer);
        }

        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { private get; set; } = null!;

        public required IImmutableList<NavigationItem> Navigation { get; init; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public async ValueTask OnNavigationItemSelectedAsync(object sender, SelectionChangedEventArgs args)
        {
            if (selectedNavigationItem != null)
            {
                selectedNavigationItem.SelectedBackgroundColor = Color.FromArgb("#ffffff");
            }

            NavigationDrawer.ToggleDrawer();
            selectedNavigationItem = args.CurrentSelection.FirstOrDefault() as NavigationItem;
            selectedNavigationItem.SelectedBackgroundColor = Color.FromArgb("#e0c0c0");
            await this.navigationProvider.SetCurrentNavigationItemAsync(selectedNavigationItem);
        }

        private void ToggleDrawer()
        {
            if (NavigationDrawer is not null)
            {
                NavigationDrawer.ToggleDrawer();
            }
        }
    }
}
