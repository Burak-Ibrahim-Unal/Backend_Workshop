using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string CarFullName { get; set; }
        public string CustomerFullName { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int TotalDays { get; }
        public int TotalCosts { get; }
    }
}
