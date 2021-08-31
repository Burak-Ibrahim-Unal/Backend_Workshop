using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager1 = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager1.GetAllProducts())
            {
                Console.WriteLine("Product name:{0}",product.ProductName);
            }
            Console.WriteLine("-----------------------------------------------------------");
            ProductManager productManager2 = new ProductManager(new EfProductDal());
            foreach (var product in productManager2.GetAllProducts())
            {
                Console.WriteLine("Product name:{0}", product.ProductName);
            }

        }
    }
}
