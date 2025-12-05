using Music2Web.Cryptography.Adapters.Drivers;
using Music2Web.Cryptography.Core;
using Music2Web.Cryptography.Ports.Drivers;

namespace Music2Web.Cryptography
{
    public static class MauiAppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureCryptography(this MauiAppBuilder builder)
        {
            builder.Services
                .AddSingleton<ISymmetricMessageSigner, SymmetricMessageSigner>()
                .AddSingleton<ISecretService, SecretService>()
                .AddSingleton<ISecretProvider, SecretProvider>()
                .AddSingleton<IHashProvider, HashProvider>();

            return builder;
        }
    }
}
