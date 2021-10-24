using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class User : IEntity
    {
        public int  Id { get; set; }
        public int UserTypeId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
