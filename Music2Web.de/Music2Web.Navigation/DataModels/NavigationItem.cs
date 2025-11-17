using Music2Web.Navigation.ValueObjects;
using System.ComponentModel;

namespace Music2Web.Navigation.DataModels
{
    public class NavigationItem : INotifyPropertyChanged
    {
        private Color selectedBackgroundColor;

        public required NavigationItemId NavigationItemId { get; init; }
        public required NavigationItemName NavigationItemName { get; init; }
        public required NavigationItemTarget NavigationItemTarget { get; init; }

        public Color SelectedBackgroundColor
        {
            get
            {
                return this.selectedBackgroundColor;
            }
            set
            {
                if (this.selectedBackgroundColor != value)
                {
                    this.selectedBackgroundColor = value;
                    this.OnPropertyChanged(nameof(SelectedBackgroundColor));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
