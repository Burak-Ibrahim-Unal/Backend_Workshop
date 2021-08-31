using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void Add(Car c);
        void Delete(Car c);
        void Update(Car c);
        List<Car> GetAllCarsByColor(int colorId);
        List<Car> GetAllCarsByBrand(int brandId);
        List<Car> GetAllCars();
    }
}
