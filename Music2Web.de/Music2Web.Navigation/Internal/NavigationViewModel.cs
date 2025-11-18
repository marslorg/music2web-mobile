using Music2Web.Navigation.DataModels;
using Music2Web.Navigation.ValueObjects;
using Syncfusion.Maui.Toolkit.NavigationDrawer;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Windows.Input;

namespace Music2Web.Navigation.Internal
{
    internal class NavigationViewModel : INavigationViewModel
    {
        private NavigationItem? selectedNavigationItem;

        public NavigationViewModel()
        {
            this.ToggleDrawerCommand = new Command(ToggleDrawer);
        }

        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { private get; set; } = null!;

        public required IImmutableList<NavigationItem> Navigation { get; init; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnNavigationItemSelected(object sender, SelectionChangedEventArgs args)
        {
            if (this.selectedNavigationItem != null)
            {
                this.selectedNavigationItem.SelectedBackgroundColor = Color.FromArgb("#ffffff");
            }

            this.NavigationDrawer.ToggleDrawer();
            this.selectedNavigationItem = args.CurrentSelection.FirstOrDefault() as NavigationItem;
            this.selectedNavigationItem.SelectedBackgroundColor = Color.FromArgb("#e0c0c0");
        }

        private void ToggleDrawer()
        {
            if (this.NavigationDrawer is not null)
            {
                this.NavigationDrawer.ToggleDrawer();
            }
        }
    }
}
