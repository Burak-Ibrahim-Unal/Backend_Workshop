using OOP_Test13_v2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Entities
{
    public class Campaign :IEntity
    {

        public int FinishTime { get; set; }
        public decimal Discount { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
