namespace BankScoringWithWebServiceDemo
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string WS_URL = "http://localhost:8082/BankScoring?pesel=88050677432";
        static async Task Main(string[] args)
        {
            for (int i = 1; i < 10000; i++)
            {
                HttpResponseMessage response = await client.GetAsync(WS_URL);
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Result: " + result);
            }

        }
    }
}

