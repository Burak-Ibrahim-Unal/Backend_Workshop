using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int Model { get; set; }
    }
}
