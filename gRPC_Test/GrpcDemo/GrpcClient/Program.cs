// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcService1;

#region Test Code 1
//var input = new HelloRequest { Name = "Burak" };

//var channel = GrpcChannel.ForAddress("https://localhost:7029");

//var client = new Greeter.GreeterClient(channel);

//var reply = await client.SayHelloAsync(input);

//Console.WriteLine(reply.Message); 
#endregion


var clientRequested = new CustomerLookupModel { UserId = 1 };

var channel = GrpcChannel.ForAddress("https://localhost:7029"); // we dont need to create multiple channel
var customerClient = new Customer.CustomerClient(channel); // but we have different clients...So we need to create as many as we need

var customer = await customerClient.GetCustomerInfoAsync(clientRequested);

Console.WriteLine($"{customer.FirstName} {customer.LastName}");


Console.ReadLine();