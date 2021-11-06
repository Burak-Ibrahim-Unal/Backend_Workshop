using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer Company1 = new CorporateCustomer() {Id=1,CompanyName="xxx",CustomerNo="123abc",TaxNumber="abc123" };
            IndividualCustomer Person1 = new IndividualCustomer() {Id=1,Name="Burak",Surname="Unal",CustomerNo="abc1234",IdentityNo="3637" };

            Customer c1 = new CorporateCustomer();
            Customer c2 = new IndividualCustomer();

            CustomerManager cm = new CustomerManager();
            cm.AddCustomer(c1);
            cm.AddCustomer(c2);
        }
    }
}
