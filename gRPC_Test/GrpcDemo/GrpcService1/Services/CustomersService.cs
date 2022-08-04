using Grpc.Core;

namespace GrpcService1.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<CustomersService> _logger;

        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }


        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if (request.UserId == 1)
            {
                output.FirstName = "Burak";
                output.LastName = "Unal";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "UserId xxx firstname";
                output.LastName = "UserId xxx lastname";
            }
            else
            {
                output.FirstName = "UserId yyy firstname";
                output.LastName = "UserId yyy lastname";
            }

            return Task.FromResult(output);
        }



        public override async Task GetNewCustomers(NewCustomerRequest request, IServerStreamWriter<CustomerModel> responseStream, ServerCallContext context)
        {
            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel
                {
                    FirstName="Frodo",
                    LastName="Baggins",
                    EmailAddress="frodo@frodo.com",
                    Age=12,
                    IsAlive=false,
                },             
                new CustomerModel
                {
                    FirstName="Bilbo",
                    LastName="Baggins",
                    EmailAddress="bilbo@bilbo.com",
                    Age=13,
                    IsAlive=true,
                },    
                new CustomerModel
                {
                    FirstName="Gandalf",
                    LastName="Baggins",
                    EmailAddress="gandalf@gandalf.com",
                    Age=12,
                    IsAlive=false,
                },
            };

            foreach (var customer in customers)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(customer);
            }


        }

    }
}
