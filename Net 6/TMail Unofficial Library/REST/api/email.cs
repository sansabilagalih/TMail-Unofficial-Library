namespace TMail_Unofficial_Library
{
    public static class email
    {
        public static async Task<string> GenerateEmail(this TMailClient client)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.Send("email/null");
                return await result.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
