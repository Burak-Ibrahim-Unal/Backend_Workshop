using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public string BrandTitle { get; set; }
        public string BrandName { get; set; }
        public string BrandSerie { get; set; }
        public decimal EngineType { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string ColorName { get; set; }
        public int Model { get; set; }
        public decimal DailyCost { get; set; }
        public bool IsActive { get; set; }
    }
}
