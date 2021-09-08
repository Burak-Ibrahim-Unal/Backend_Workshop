using OOP_Test12_Abstract_vs_Interface.Abstract;
using OOP_Test12_Abstract_vs_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test12_Abstract_vs_Interface.Concrete
{
    public class CafeCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public CafeCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        private void CheckRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
