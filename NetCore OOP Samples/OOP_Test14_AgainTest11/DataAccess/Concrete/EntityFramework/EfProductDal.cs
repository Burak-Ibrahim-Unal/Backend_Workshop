using Core.DataAccess;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDTO> GetProductDetails()
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var result = from p in nc.Products
                             join c in nc.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDTO
                             { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
