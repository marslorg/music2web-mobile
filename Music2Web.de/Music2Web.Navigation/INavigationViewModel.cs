using Music2Web.Navigation.DataModels;
using Syncfusion.Maui.Toolkit.NavigationDrawer;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Windows.Input;

namespace Music2Web.Navigation
{
    public interface INavigationViewModel : INotifyPropertyChanged
    {
        public ICommand ToggleDrawerCommand { get; }

        public SfNavigationDrawer? NavigationDrawer { set; }

        public IImmutableList<NavigationItem> Navigation { get; }

        public void OnNavigationItemSelected(object sender, SelectionChangedEventArgs args);
    }
}
