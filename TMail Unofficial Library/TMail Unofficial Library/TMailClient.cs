namespace TMail_Unofficial_Library
{
    public class TMailClient
    {
        public string URL { get; set; }
        public string Api_Key { get; set; }

        public TMailHttpClient HttpClient { get; private set; }

        public TMailClient(string url, string api_key)
        {
            HttpClient = new TMailHttpClient(this);
            Api_Key = api_key;
            URL = url;
        }

    }
}
