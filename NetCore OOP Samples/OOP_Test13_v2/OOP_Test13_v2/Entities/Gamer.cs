using OOP_Test13_v2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Entities
{
   public class Gamer : IEntity
    {

        public string SurName { get; set; }
        public int Age { get; set; }
        public string IdentityNo { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
