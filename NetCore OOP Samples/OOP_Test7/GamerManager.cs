using System;
using System.Collections.Generic;
using System.Text;

namespace Test3
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("New record added.");
            }
            else
            {
                Console.WriteLine("Validation unsuccessful.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Record deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Record updated.");
        }
    }
}
