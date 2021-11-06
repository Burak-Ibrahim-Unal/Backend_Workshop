using System;
using System.Collections.Generic;
using System.Text;
using OOP_Test12_Abstract_vs_Interface.Entities;

namespace OOP_Test12_Abstract_vs_Interface.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db:" + customer.Name +" "+customer.SurName);
        }
    }
}
