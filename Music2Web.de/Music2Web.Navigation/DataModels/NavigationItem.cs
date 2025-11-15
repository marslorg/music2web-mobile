using Music2Web.Navigation.ValueObjects;

namespace Music2Web.Navigation.DataModels
{
    public class NavigationItem
    {
        public required NavigationItemId NavigationItemId { get; init; }
        public required NavigationItemName NavigationItemName { get; init; }
        public required NavigationItemTarget NavigationItemTarget { get; init; }
    }
}
