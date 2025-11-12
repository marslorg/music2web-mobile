using Syncfusion.Maui.Toolkit.NavigationDrawer;
using System.ComponentModel;
using System.Windows.Input;

namespace Music2Web.Navigation
{
    public interface INavigationViewModel : INotifyPropertyChanged
    {
        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { set; }
    }
}
