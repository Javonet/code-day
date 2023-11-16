namespace PythonLangchainDemo
{
    using Javonet.Netcore.Sdk.Internal;
    using Javonet.Netcore.Utils;
    using Javonet.Netcore.Sdk;
    internal class LangchainWrapper
    {
        private InvocationContext llm;
        private readonly TcpConnectionData remoteConnectionData = new TcpConnectionData("127.0.0.1", 8080);
        private readonly static string licenceKey = "t2B3-Fz2w-Nx92-o2CK-w4WX";

        public LangchainWrapper()
        {
            Javonet.Activate(licenceKey);

            var pythonRuntime = Javonet.InMemory().Python();
            //var pythonRuntime = Javonet.Tcp(remoteConnectionData).Python();

            llm = pythonRuntime.GetType("langchain.llms.OpenAI").CreateInstance().Execute();
        }

        public string Invoke(string prompt)
        {
            var response = llm.InvokeInstanceMethod("invoke", prompt).Execute();
            return (string)response.GetValue();
        }
    }
}
