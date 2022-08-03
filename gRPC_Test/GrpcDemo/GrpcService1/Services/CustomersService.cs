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
            CustomerModel output= new CustomerModel();

            if (request.UserId == 1)
            {
                output.FirstName = "Burak";
                output.LastName = "Unal";
            }
            else if (request.UserId==2)
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

    }
}
