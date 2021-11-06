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
            //ProductManager productManager1 = new ProductManager(new InMemoryProductDal());
            //foreach (var product in productManager1.GetAllProducts())
            //{
            //    Console.WriteLine("Product name:{0}",product.ProductName);
            //}

            ProductManager productManager2a = new ProductManager(new EfProductDal());
            foreach (var product in productManager2a.GetAllByCategoryId(1))
            {
                Console.WriteLine("Product Name:{0} with category id: {1}", product.ProductName, product.CategoryId);
            }

            Console.WriteLine("-----------------------------------------------------------");

            ProductManager productManager2b = new ProductManager(new EfProductDal());
            foreach (var product in productManager2b.GetAllByUnitPrice(10, 30))
            {
                Console.WriteLine("Product Name:{0} with UnitPrice between 10-30: {1}USD", product.ProductName, product.UnitPrice);
            }


            Console.WriteLine("-----------------------------------------------------------");

            ProductManager productManager2 = new ProductManager(new EfProductDal());
            foreach (var product in productManager2.GetAllProducts())
            {
                Console.WriteLine("Product name:{0}", product.ProductName);
            }

            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
