using Core.Utilities;
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
        IDataResult<List<Car>> GetAllCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetAllCarsByColorId(int colorId);
        IDataResult<List<Car>> GetAllCarsByModel(int minModel, int maxModel);
        IDataResult<Car> GetCarById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car c);

    }
}
