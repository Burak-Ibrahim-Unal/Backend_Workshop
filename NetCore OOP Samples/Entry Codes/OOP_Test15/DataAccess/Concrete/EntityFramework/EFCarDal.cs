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
    public class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var added = nc.Entry(entity);
                added.State = EntityState.Added;
                nc.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var deleted = nc.Entry(entity);
                deleted.State = EntityState.Deleted;
                nc.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                return nc.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                return nc.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
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
