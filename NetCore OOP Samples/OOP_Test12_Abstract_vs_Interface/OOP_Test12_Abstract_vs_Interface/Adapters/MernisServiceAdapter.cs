using MernisServiceReference;
using OOP_Test12_Abstract_vs_Interface.Abstract;
using OOP_Test12_Abstract_vs_Interface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test12_Abstract_vs_Interface.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNo), customer.Name, customer.SurName, customer.BirthDay.Year);
            return true;
        }
    }
}
