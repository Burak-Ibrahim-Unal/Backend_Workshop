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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarsTestContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarsTestContext ctc = new CarsTestContext())
            {
                var DbResult = (from c in ctc.Customers
                                join u in ctc.Users on c.UserId equals u.Id 
                                select new CustomerDetailDto
                                {
                                    Id = c.Id,
                                    Name = c.Name,
                                    SurName = c.SurName,
                                    FullName = c.FullName,
                                    Address = c.Address,
                                    Phone = c.Phone,                                    
                                }).ToList();
                return DbResult;
            }
        }
    }
}
