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
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var added = nc.Entry(entity);
                added.State = EntityState.Added;
                nc.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var deleted = nc.Entry(entity);
                deleted.State = EntityState.Deleted;
                nc.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                return nc.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                return nc.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
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
