using System;

public static void Run(string myEventHubMessage, TraceWriter log, out string outputSbMsg)
{
    log.Info($"C# Event Hub trigger function processed a message : {myEventHubMessage}");
    outputSbMsg = myEventHubMessage;
}