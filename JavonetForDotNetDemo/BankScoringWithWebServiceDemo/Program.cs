namespace BankScoringWithWebServiceDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var pesel = 83030411751;
            var result = await WebServiceClient.getResultAsync(pesel);
            Console.WriteLine("WebService result:" + result);
        }
    }
}

