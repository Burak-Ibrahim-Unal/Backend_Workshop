using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class BrandDetail : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandTitle { get; set; }
        public string BrandName { get; set; }
        public string BrandSerie { get; set; }
        public decimal EngineType { get; set; }
        public string GearType { get; set; }
        public string FuelType { get; set; }
    }
}
