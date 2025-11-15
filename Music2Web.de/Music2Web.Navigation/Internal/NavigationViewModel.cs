using Music2Web.Navigation.DataModels;
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
            this.ToggleDrawerCommand = new Command(ExecuteToggleDrawerCommand);
        }

        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { private get; set; } = null!;

        public required IImmutableList<NavigationItem> Navigation { get; init; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void ExecuteToggleDrawerCommand()
        {
            if (this.NavigationDrawer is not null)
            {
                this.NavigationDrawer.ToggleDrawer();
            }
        }
    }
}
