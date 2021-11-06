using OOP_Test12_Abstract_vs_Interface.Abstract;
using OOP_Test12_Abstract_vs_Interface.Adapters;
using OOP_Test12_Abstract_vs_Interface.Concrete;
using OOP_Test12_Abstract_vs_Interface.Entities;
using System;

namespace OOP_Test12_Abstract_vs_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new CafeCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {
                Name = "Burak", SurName = "Unal", BirthDay = new DateTime(1987, 07, 22), Id = 1, IdentityNo = "36376565348"
            });
            Console.ReadLine();
        }
    }
}
