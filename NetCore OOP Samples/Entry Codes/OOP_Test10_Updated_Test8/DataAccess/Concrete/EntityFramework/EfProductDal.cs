using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext nw = new NorthwindContext())
            {
                var addedEntity = nw.Entry(entity);
                addedEntity.State = EntityState.Added;
                nw.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext nw = new NorthwindContext())
            {
                var deletedEntity = nw.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                nw.SaveChanges();
            }
        }

        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext nw = new NorthwindContext())
            {
                return nw.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext nw = new NorthwindContext())
            {
                return filter == null
                    ? nw.Set<Product>().ToList()
                    : nw.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext nw = new NorthwindContext())
            {
                var updatedEntity = nw.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                nw.SaveChanges();
            }
        }
    }
}
