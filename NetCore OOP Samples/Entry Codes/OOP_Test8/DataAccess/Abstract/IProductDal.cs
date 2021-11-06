using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();

        void Add(Product p);
        void Update(Product p);
        void Delete(Product p);
        List<Product> GetAllByCategory(int categoryId);
    }
}
