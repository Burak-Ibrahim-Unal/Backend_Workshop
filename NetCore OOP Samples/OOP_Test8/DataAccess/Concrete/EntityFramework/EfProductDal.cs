using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product p)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product p)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return new List<Product> { new Product { ProductName = "Tablet" }, new Product { ProductName = "Mobile Phone" } };
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
