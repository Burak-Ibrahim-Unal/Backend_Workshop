using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckCarFullNameExists(car.FullName));

            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);
            return new Result(true, Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.IsActive == true), Messages.ActiveCarListed);
        }


        public IDataResult<List<Car>> GetAllCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<Car>> GetAllCarsByModel(int minModel, int maxModel)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Model > minModel && c.Model < maxModel));
        }

        public IDataResult<List<Car>> GetAllCarsWithDeleted()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.AllCarsListed);
        }

        IDataResult<List<CarDetailDto>> ICarService.GetCarByColor(string color)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(c => c.ColorName.ToLower() == color.ToLower()).ToList());
        }
        public IDataResult<Car> GetCarById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintanceTime);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
            }
        }


        private IResult CheckCarFullNameExists(string carFullName)
        {
            // select count(*) from cars where CarName=carName
            //Way1:
            var result = _carDal.GetAll(p => p.FullName.ToLower() == carFullName.ToLower()).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }

            #region 2nd Method
            ////Way2
            //var result2 = _carDal.GetAll(p => p.CarName.ToLower() == carName.ToLower()).Count > 0;
            //if (result2)
            //{
            //    return new ErrorResult(Messages.CarNameAlreadyExists);
            //} 
            #endregion
            #region 3rd Method
            ////Way3
            //var result3 = _carDal.GetAll(p => p.CarName.ToLower() == carName.ToLower());
            //if (result3 == null)
            //{
            //    return new ErrorResult(Messages.CarNameAlreadyExists);
            //} 
            #endregion
            return new SuccessResult();
        }


    }
}
