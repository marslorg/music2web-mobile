namespace Music2Web.Content.ValueObjects
{
    public record Music2WebAddress
    {
        private const string Scheme = "https://";

        private string? value;

        public Music2WebAddress(string? Value)
        {
            var result = Value;
            var trimString = Scheme + this.Host;

            if (result != null && result.StartsWith(trimString))
            {
                result = result.Substring(trimString.Length);
            }

            this.value = result;
        }

        public string Value => value != null ? $"{Scheme}{this.Host}{this.value}" : $"{Scheme}{this.Host}";

        public string Host => "www.music2web.de/";

        public string Path => this.value ?? "";
    }
}
