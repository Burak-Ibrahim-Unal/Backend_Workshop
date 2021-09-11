using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Customer :IEntity
    {
        public string CustomerId { get; set; } // it is string because of the northwind db bug
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
