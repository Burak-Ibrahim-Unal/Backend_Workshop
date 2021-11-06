using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class UpdatedUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {

            return true;

        }
    }
}
