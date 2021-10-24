using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandDetailsId { get; set; }
        public int ColorId { get; set; }
        public int Model { get; set; }
        public decimal DailyCost { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }

    }
}
