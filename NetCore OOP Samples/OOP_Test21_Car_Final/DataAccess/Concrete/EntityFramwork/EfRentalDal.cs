using Core.DataAccess;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsTest>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            throw new NotImplementedException();
        }
    }
}
