using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class CustomerDetailDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
