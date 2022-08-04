// See https://aka.ms/new-console-template for more information
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
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
Console.WriteLine();
Console.WriteLine("New customers...");
Console.WriteLine();


using (var call = customerClient.GetNewCustomers(new NewCustomerRequest()))
{
    while (await call.ResponseStream.MoveNext())
    {
        var CurrentCustomer = call.ResponseStream.Current;
        Console.WriteLine($"{CurrentCustomer.FirstName} {CurrentCustomer.LastName} {CurrentCustomer.EmailAddress }");

    }
}

Console.ReadLine();