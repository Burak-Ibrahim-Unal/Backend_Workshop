using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class ProductDetailDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int UnitsInStock { get; set; }
    }
}
