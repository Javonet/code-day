namespace BankScoringWithWebServiceDemo
{
    internal class WebServiceClient
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<int> getResultAsync(long pesel)
        {
            string WS_URL = string.Format("http://localhost:8082/BankScoring?pesel={0}", pesel);
            HttpResponseMessage response = await client.GetAsync(WS_URL);
            var result = await response.Content.ReadAsStringAsync();
            return Int32.Parse(result);
        }
    }
}
