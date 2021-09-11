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
    public class EfBrandDal : IBrandDal

    {
        public void Add(Brand entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var added = nc.Entry(entity);
                added.State = EntityState.Added;
                nc.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var deleted = nc.Entry(entity);
                deleted.State = EntityState.Deleted;
                nc.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                return nc.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                return nc.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var updated = nc.Entry(entity);
                updated.State = EntityState.Modified;
                nc.SaveChanges();
            }
        }
    }
}
