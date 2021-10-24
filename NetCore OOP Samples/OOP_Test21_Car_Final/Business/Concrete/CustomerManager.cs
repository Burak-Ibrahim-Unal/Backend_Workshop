using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new Result(true, Messages.CustomerAdded); // Test SuccessResult instead of Result
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            //if (DateTime.Now.Hour==2)
            //{
            //    return new ErrorDataResult<List<Customer>>(Messages.MaintanceTime);
            //}
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public IDataResult<Customer> GetCustomerByCustomerId(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == customerId));

        }

        public IDataResult<List<Customer>> GetAllCustomersByFullName(string fullName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.FullName.ToLower() == fullName.ToLower()), Messages.CustomerListed);
        }

        public IDataResult<List<Customer>> GetAllCustomersByName(string name)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Name.ToLower() == name.ToLower()), Messages.CustomerListed);
        }

        public IDataResult<List<Customer>> GetAllCustomersBySurName(string surName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.SurName.ToLower() == surName.ToLower()), Messages.CustomerListed);
        }


        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails());
        }


    }
}
