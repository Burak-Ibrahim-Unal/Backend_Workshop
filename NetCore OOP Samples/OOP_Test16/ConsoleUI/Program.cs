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
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("Product Name:{0} ------- Price: {1}TL ------- Category Name: {2}", product.ProductName, product.UnitPrice, product.CategoryName);
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");


        }
    }
}
