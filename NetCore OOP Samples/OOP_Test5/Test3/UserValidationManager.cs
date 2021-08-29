using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear > 1950 && gamer.Name == "Burak" && gamer.Surname == "Unal" && gamer.IdentityNo == "12345" && gamer.BirthYear == 1987)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
