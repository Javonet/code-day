namespace PythonLangchainDemo
{
    using Javonet.Netcore.Sdk;
    using Javonet.Netcore.Utils;
    internal class Program
    {
        static void Main(string[] args)
        {
            Javonet.Activate("t2B3-Fz2w-Nx92-o2CK-w4WX");
            var remoteConnectionData = new TcpConnectionData("127.0.0.1", 8080);
            var remoteNode = Javonet.Tcp(remoteConnectionData).Python();
            var openAIType = remoteNode.GetType("langchain.llms.OpenAI").Execute();

            var llm = openAIType.CreateInstance().Execute();
            var response = llm.InvokeInstanceMethod("invoke", "What can i do in Warsaw?").Execute();
            var result = response.GetValue();
            Console.WriteLine(result);
        }
    }
}
