using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("*** Higher than 10TL price and lower than 10 pieces of stock and ordered by Stock ***\n");
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(" Product Name:{0} -------  Price: {1}TL ------- Stock: {2}Pieces ------- Category Name: {3} ", product.ProductName, product.UnitPrice, product.UnitStock, product.CategoryName);
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("*** All orders where address contain number  57 \n"); // it is only fantasy... :)

            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var order in orderManager.GetOrderDetails())
            {
                Console.WriteLine("Order Id:{0} ------- Employee First Name: {1}, Employee Last Name:{2} ------- Company Name: {2} ------- Contact Name: {3} ------- Address:{4}", order.OrderId, order.EmployeeFirstName, order.EmployeeLastName, order.CompanyName, order.ContactName, order.Address);
            }

            Console.ReadLine();
        }
    }
}
