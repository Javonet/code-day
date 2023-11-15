using Javonet.Netcore.Utils;

Console.WriteLine("Hello, World!");

Javonet.Netcore.Sdk.Javonet.Activate("t2B3-Fz2w-Nx92-o2CK-w4WX");

var pythonNode = new TcpConnectionData("127.0.0.1", 8080);
var netcoreNode = new TcpConnectionData("127.0.0.1", 8081);

var pythonRuntime = Javonet.Netcore.Sdk.Javonet.Tcp(pythonNode).Python();
var netcoreRuntime = Javonet.Netcore.Sdk.Javonet.Tcp(netcoreNode).Netcore();

netcoreRuntime.LoadLibrary("Bank.Scoring.dll");

var typee = netcoreRuntime.GetType("Bank.Scoring.ScoringEstimator").Execute();
var response = typee.CreateInstance().InvokeInstanceMethod("ComputeScore", 90052611711).Execute();
Console.WriteLine(response.GetValue());

// get type from the runtime
var mathType = pythonRuntime.GetType("math").Execute();

for (int i = 0; i < 100000; i++)
{
    // get type's static field
    var response2 = mathType.GetStaticField("pi").Execute();

    // get value from response
    var result2 = (float)response2.GetValue();

    // write result to console
    System.Console.WriteLine(i + ": " + result2);

}

try
{
    //var openAIType = pythonRuntime.GetType("langchain.llms.OpenAI").Execute();
    //var chatOpenAIType = pythonRuntime.GetType("langchain.chat_models.ChatOpenAI").Execute();

    //Console.WriteLine(openAIType.GetValue());
    //Console.WriteLine(chatOpenAIType.GetValue());

    //var llm = openAIType.CreateInstance("text-davinci-003").Execute();
    //var chat_model = chatOpenAIType.CreateInstance().Execute();

    //Console.WriteLine(llm.GetValue());
    //Console.WriteLine(chat_model.GetValue());

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
