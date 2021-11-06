using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product> {
                new Product
                {
                    Id=1,Name="Computer"
                },
                new Product
                {
                    Id=2,Name="Tablet"
                }
            };
        }
    }
}
