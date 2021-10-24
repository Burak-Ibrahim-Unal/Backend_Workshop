using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAllCars();
        IDataResult<List<Car>> GetAllCarsWithDeleted();
        IDataResult<List<Car>> GetAllCarsByColorId(int colorId);
        IDataResult<List<Car>> GetAllCarsByModel(int minModel, int maxModel);
        IDataResult<Car> GetCarById(int carId);
        IDataResult<List<CarDetailDto>> GetCarByColor(string color);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsFuel(string fuel);
        IResult Add(Car car);

    }
}
