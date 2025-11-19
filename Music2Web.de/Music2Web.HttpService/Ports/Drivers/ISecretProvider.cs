using Music2Web.HttpService.ValueObjects;

namespace Music2Web.HttpService.Ports.Drivers
{
    internal interface ISecretProvider
    {
        public UserName UserName { get; }
        public Password Password { get; }
    }
}
