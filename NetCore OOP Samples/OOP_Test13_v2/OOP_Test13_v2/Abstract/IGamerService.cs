using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer p);
        void Delete(Gamer p);
        void Update(Gamer p);
    }
}
