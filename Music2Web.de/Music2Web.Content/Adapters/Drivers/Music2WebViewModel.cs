using CommunityToolkit.Mvvm.ComponentModel;
using Music2Web.Content.ValueObjects;

namespace Music2Web.Content.Adapters.Drivers
{
    internal partial class Music2WebViewModel : ObservableObject, IMusic2WebViewModel
    {
        [ObservableProperty]
        private Music2WebAddress address;

        [ObservableProperty]
        private Music2WebUserAgent userAgent;

        public Music2WebViewModel()
        {
            this.Address = new Music2WebAddress("http://www.music2web.de");

            this.UserAgent = new Music2WebUserAgent("music2webapp;424a6393c388882eadef0ac5402bd2b9;01ef09441acf2f2b9d7b255a9708789226bda5c7dac249b513dd36e27fe6d93f15be77ce34e4561ff35fa3fd2c0f4e57dca4d790cfcff6784f0b1a91f4c26b88");
        }
    }
}
