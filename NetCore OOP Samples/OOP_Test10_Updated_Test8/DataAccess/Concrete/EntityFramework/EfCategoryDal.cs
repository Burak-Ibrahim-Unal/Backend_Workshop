using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category GetProduct(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

 
        public List<Category> GetAllProducts(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();


        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
