using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetAllProductDetails()
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var DbResult = (from p in nc.Products
                               join c in nc.Categories
                               on p.CategoryId equals c.CategoryId
                               select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName }).ToList();
                return DbResult;
            }
        }
    }
}
