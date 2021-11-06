using System;
using OOP_Test4.Dal;
using OOP_Test4.Entity;

namespace OOP_Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            var productDal= new EfProductDal();
            var categorydal = new  EfCategoryDal();
            var mysqldal = new MysqlProductDal();
            var productRepoDal1= new ProductManager(new EfProductDal());
            var productRepoDal2= new ProductManager(new MysqlProductDal());
            
            productDal.Create(new Product());
            categorydal.Create(new Entity.Category());
            mysqldal.Create(new Product());
            productRepoDal1.Create(new Product());
            productRepoDal2.Create(new Product());

        }
    }
}
