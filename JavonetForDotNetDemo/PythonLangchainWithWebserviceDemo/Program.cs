namespace PythonLangchainWithWebServiceDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var prompt = "Say hello to my CodeDay Audience";
            var result = await WebServiceClient.getResultAsync(prompt);
            Console.WriteLine("WebService result:" + result);
        }
    }
}
