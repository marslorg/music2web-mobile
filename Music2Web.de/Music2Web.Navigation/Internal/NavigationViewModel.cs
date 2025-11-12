using Syncfusion.Maui.Toolkit.NavigationDrawer;
using System.ComponentModel;
using System.Windows.Input;

namespace Music2Web.Navigation.Internal
{
    internal class NavigationViewModel : INavigationViewModel
    {
        public NavigationViewModel()
        {
            this.ToggleDrawerCommand = new Command(() => ExecuteToggleDrawerCommand());
        }

        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { private get; set; } = null!;

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
