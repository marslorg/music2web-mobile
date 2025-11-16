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
        public NavigationViewModel()
        {
            this.ToggleDrawerCommand = new Command(ToggleDrawer);
        }

        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { private get; set; } = null!;

        public required IImmutableList<NavigationItem> Navigation { get; init; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnNavigationItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            this.NavigationDrawer.ToggleDrawer();
            var selectedNavigationItem = args.SelectedItem as NavigationItem;
            Console.WriteLine(selectedNavigationItem.NavigationItemTarget.Value.AbsoluteUri);
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
