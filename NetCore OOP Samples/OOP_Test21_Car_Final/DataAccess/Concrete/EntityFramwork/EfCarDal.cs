using Core.DataAccess;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext nc = new NorthwindContext())
            {
                var DbResult = (from c in nc.Cars
                                join b in nc.Brands on c.BrandId equals b.Id
                                join co in nc.Colors on c.ColorId equals co.Id
                                select new CarDetailDto
                                {
                                    Id = c.Id,
                                    BrandName = b.BrandName,
                                    ColorName = co.ColorName,
                                    Model = c.Model
                                }).ToList();
                return DbResult;
            }
        }
    }
}
