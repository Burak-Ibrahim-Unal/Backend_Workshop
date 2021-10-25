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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsTestContext>, ICarDal
    {
       
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsTestContext ctc = new CarsTestContext())
            {

                #region Berdan
                //var DbResult = (from co in ctc.Colors
                //                join c in ctc.Cars on co.Id equals c.ColorId
                //                join bd in ctc.BrandDetails on c.BrandDetailsId equals bd.Id
                //                select new CarDetailDto
                //                {
                //                    Id = c.Id,
                //                    BrandTitle = bd.BrandTitle,
                //                    BrandName = bd.BrandName,
                //                    BrandSerie = bd.BrandSerie,
                //                    EngineType = bd.EngineType,
                //                    FuelType = bd.FuelType,
                //                    GearType = bd.GearType,
                //                    ColorName = co.ColorName,
                //                    Model = c.Model,
                //                    DailyCost = c.DailyCost,
                //                    IsActive = c.IsActive
                //                }).ToList();
                //return DbResult; 
                #endregion
                var DbResult = (from c in ctc.Cars
                                join bd in ctc.BrandDetails on c.BrandDetailsId equals bd.Id
                                join co in ctc.Colors on c.ColorId equals co.Id
                                select new CarDetailDto
                                {
                                    Id = c.Id,
                                    BrandTitle = bd.BrandTitle,
                                    BrandName = bd.BrandName,
                                    BrandSerie = bd.BrandSerie,
                                    EngineType = bd.EngineType,
                                    FuelType = bd.FuelType,
                                    GearType = bd.GearType,
                                    ColorName = co.ColorName,
                                    Model = c.Model,
                                    DailyCost = c.DailyCost,
                                    IsActive = c.IsActive
                                }).ToList();
                return DbResult;
            }
        }

        public List<CarDetailDto> GetCarDetailsFuel(string fuel)
        {
            throw new NotImplementedException();
        }
    }
}
