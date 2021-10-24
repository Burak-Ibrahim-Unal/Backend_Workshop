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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsTestContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarsTestContext ctc = new CarsTestContext())
            {
                var DbResult = (from re in ctc.Rentals
                                join ca in ctc.Cars on re.CarId equals ca.Id
                                join cu in ctc.Customers on re.CustomerId equals cu.Id
                                select new RentalDetailDto
                                {
                                    Id = re.Id,
                                    CarFullName=ca.FullName,
                                    CustomerFullName=cu.FullName,
                                    RentalDate = re.RentalDate,
                                    ReturnDate = re.ReturnDate,
                                }).ToList();
                return DbResult;
            }
        }
    }
}
