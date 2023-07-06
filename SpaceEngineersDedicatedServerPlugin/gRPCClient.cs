using System;
using Grpc.Net.Client;
//using GrpcGreeterClient;

namespace SpaceEngineersDedicatedServerPlugin
{
    public class gRPCClient
    {
        GrpcChannel channel;
        public gRPCClient()
        {
            //channel = GrpcChannel.ForAddress("https://localhost:50051");
            //var invoker = channel.CreateCallInvoker();
            //var client = new Greeter.GreeterClient(channel);
            //var reply = await client.SayHelloAsync(
            //                  new HelloRequest { Name = "GreeterClient" });
            //Console.WriteLine("Greeting: " + reply.Message);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }
}