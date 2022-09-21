namespace TMail_Unofficial_Library
{
    public static class email
    {
        internal static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static async Task<string> GenerateEmail(this TMailClient client, int email_length)
        {
            try
            {
                HttpResponseMessage result = await client.HttpClient.Send("email/"+ RandomString(email_length));
                return await result.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
