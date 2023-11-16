namespace BankScoringWithJavonetDemo
{
    using Javonet.Netcore.Sdk;
    using Javonet.Netcore.Utils;

    internal class Program
    {
        static void Main(string[] args)
        {
            Javonet.Activate("t2B3-Fz2w-Nx92-o2CK-w4WX");
            var remoteConnectionData = new TcpConnectionData("127.0.0.1", 8081);
            var remoteNode = Javonet.Tcp(remoteConnectionData).Netcore();
            remoteNode.LoadLibrary("Bank.Scoring.dll");
            var scoringEstimator = remoteNode.GetType("Bank.Scoring.ScoringEstimator").CreateInstance().Execute();
            var response = scoringEstimator.InvokeInstanceMethod("ComputeScore", 87052611711).Execute();
            var result = response.GetValue();
            Console.WriteLine("Result: " + result);
        }
    }
}
