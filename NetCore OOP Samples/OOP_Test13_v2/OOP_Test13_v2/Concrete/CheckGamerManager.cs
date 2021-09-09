
using OOP_Test13_v2.Abstract;
using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Concrete
{
    public class CheckGamerManager : ICheckIdService
    {
        public bool CheckPerson(Gamer g1)
        {
            return true;
        }
    }
}
