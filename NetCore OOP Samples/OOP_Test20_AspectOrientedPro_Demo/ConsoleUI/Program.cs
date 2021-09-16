using Business.Abstract;
using Business.Concrete;
using Core.CrossCuttingConcerns.Caching.Concrete;
using Core.CrossCuttingConcerns.Logging.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProductService productService = new ProductManager(new EfProductDal(),new Logger(),new Cache()); //contrary to solid principles
            //foreach (var product in productService.GetAll())
            //{
            //    Console.WriteLine(product.Name);
            //}

            //Console.WriteLine("-----------------------------------------------");

            //IProductService productService2 = new ProductManager(new NhProductDal(), new Logger(), new Cache()); //contrary to solid principles
            //foreach (var product in productService2.GetAll())
            //{
            //    Console.WriteLine(product.Name);
            //}
            //Console.ReadLine();

            IProductService productService = new ProductManager(new EfProductDal()); //contrary to solid principles
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine("-----------------------------------------------");

            IProductService productService2 = new ProductManager(new NhProductDal()); //contrary to solid principles
            foreach (var product in productService2.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}
