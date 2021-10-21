using System.Net;

namespace TMail_Unofficial_Library
{
    public class TMailHttpClient
    {
        private readonly TMailClient _tmailClient;

        public TMailHttpClient(TMailClient TMailClient)
        {
            _tmailClient = TMailClient;
        }

        public async Task<HttpResponseMessage> Send(string endpoint)
        {
            var webClient = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            });

            while (true)
            {
                try
                {
                    webClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/x-www-form-urlencoded");
                    HttpResponseMessage response =
                    await webClient.GetAsync(_tmailClient.URL + "/api/" + endpoint + "/" + _tmailClient.Api_Key);
                    return response;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
    }
}
