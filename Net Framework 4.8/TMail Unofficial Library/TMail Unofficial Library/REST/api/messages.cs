using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TMail_Unofficial_Library
{
    public static class messages
    {
        public static async Task<string> CheckEmail(this TMailClient client, string email)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.Send("messages/" + email);
                if (await result.Content.ReadAsStringAsync() == "[]")
                {
                    return "Waiting.";
                }
                else
                {
                    return await result.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
