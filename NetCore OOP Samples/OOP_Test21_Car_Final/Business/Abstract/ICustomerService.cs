using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAllCustomers();
        IDataResult<List<Customer>> GetAllCustomersByName(string name);
        IDataResult<List<Customer>> GetAllCustomersBySurName(string surName);
        IDataResult<List<Customer>> GetAllCustomersByFullName(string fullName);
        IDataResult<Customer> GetCustomerByCustomerId(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        IResult Add(Customer customer);

    }
}
