using OOP_Test12_Abstract_vs_Interface.Abstract;
using OOP_Test12_Abstract_vs_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test12_Abstract_vs_Interface.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            //This is check service to check identity number of Turkish Republic
            return true;
        }
    }
}
