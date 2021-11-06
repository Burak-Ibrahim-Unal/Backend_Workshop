using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _carservice;
        public CarManager(ICarDal carService)
        {
            _carservice = carService;
        }

        public void Add(Car car)
        {
            _carservice.Add(car);
        }

        public void Delete(Car car)
        {
            _carservice.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carservice.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carservice.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carservice.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carservice.Update(car);
        }
    }
}
