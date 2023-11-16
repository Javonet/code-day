namespace PythonLangchainDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var LLM = new LangchainWrapper();
            var prompt = "Say hello to my CodeDay Audience";
            var response = LLM.Invoke(prompt);
            
            Console.WriteLine(response);
        }
    }
}
