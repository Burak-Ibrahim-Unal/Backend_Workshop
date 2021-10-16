using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental c)
        {
            if (c.RentalDate > DateTime.Now.Date)
            {
                return new ErrorResult(Messages.RentalDateInvalid);
            }
            _rentalDal.Add(c);
            return new Result(true,Messages.RentalAdded); // Test SuccessResult instead of Result
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            if (DateTime.Now.Hour==2)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetAllRentalsByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        public IDataResult<List<Rental>> GetAllRentalsByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAllRentalsByRentalDates(DateTime rentalDate, DateTime returnDate)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAllRentalsByTotalRentalCosts(int minCosts, int maxCosts)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAllRentalsByTotalRentalDays(int rentalDays, int returnDays)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetRentalById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            throw new NotImplementedException();
        }
    }
}
