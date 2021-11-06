using OOP_Test12_Abstract_vs_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test12_Abstract_vs_Interface.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckRealPerson(Customer customer);
    }
}
