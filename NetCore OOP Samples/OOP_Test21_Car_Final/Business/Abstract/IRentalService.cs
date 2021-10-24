using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAllRentals();
        IDataResult<List<Rental>> GetAllRentalsByCarId(int carId);
        IDataResult<List<Rental>> GetAllRentalsByCustomerId(int customerId);
        IDataResult<List<Rental>> GetAllRentalsByRentalDates(DateTime rentalDate, DateTime returnDate);
        IDataResult<List<Rental>> GetAllRentalsByTotalRentalDays(int rentalDays, int returnDays);
        IDataResult<List<Rental>> GetAllRentalsByTotalRentalCosts(int minCosts, int maxCosts);
        IDataResult<Rental> GetRentalById(int rentalId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental c);
    }
}
