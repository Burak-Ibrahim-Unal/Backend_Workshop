using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {

        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=2,Name="Opel",DailyPrice=30000,Description="Sport",ModelYear="2020",},
                new Car{Id=2,BrandId=1,ColorId=2,Name="Mercedes",DailyPrice=40000,Description="Family",ModelYear="2019",},
                new Car{Id=3,BrandId=2,ColorId=2,Name="Bmv",DailyPrice=25000,Description="Classic",ModelYear="2021",},
                new Car{Id=4,BrandId=3,ColorId=2,Name="Toyota",DailyPrice=35000,Description="Family",ModelYear="2020",},
                new Car{Id=5,BrandId=3,ColorId=2,Name="Skoda",DailyPrice=50000,Description="Family",ModelYear="2018",},
            };
        }
        public void Add(Car c)
        {
            _cars.Add(c);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Car> GetAllCarsByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllCarsByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.Name = "Honda";
            CarToUpdate.DailyPrice = 60000; 
        }
    }
}
