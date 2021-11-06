using OOP_Test13_v2.Abstract;
using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Adapters
{
    public class CheckIdAdapter : ICheckIdService
    {
        public bool CheckPerson(Gamer g1)
        {
            if (g1.Id == 1 && g1.Name == "Burak" && g1.SurName == "Unal" && g1.IdentityNo == "abc123" && g1.Age == 34) return true;
            else return false;        
        }
    }
}
