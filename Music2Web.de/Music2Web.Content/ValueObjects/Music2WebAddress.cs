namespace Music2Web.Content.ValueObjects
{
    public record Music2WebAddress
    {
        private const string Scheme = "https://";

        private string? value;

        public Music2WebAddress(string? Value)
        {
            this.value = Value;
        }

        public string Value => value != null ? $"{Scheme}{this.Host}{this.value}" : $"{Scheme}{this.Host}";

        public string Host => "www.music2web.de/";

        public string Path => this.value ?? "";
    }
}
