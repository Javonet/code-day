namespace PythonLangchainWithWebServiceDemo
{
    internal class WebServiceClient
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<string> getResultAsync(string prompt)
        {
            string WS_URL = string.Format("http://localhost:8083/api/invoke_llm?prompt={0}", prompt);
            HttpResponseMessage response = await client.GetAsync(WS_URL);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
