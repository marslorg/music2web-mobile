namespace Music2Web.Navigation.Ports.Driven
{
    internal interface IHttpServiceAdapter
    {
        public ValueTask<T> GetJsonResponseAsync<T>(Uri uri) where T : class;
    }
}
