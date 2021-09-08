using OOP_Test12_Abstract_vs_Interface.Abstract;
using System;

namespace OOP_Test12_Abstract_vs_Interface.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public string IdentityNo { get; set; }
    }
}
