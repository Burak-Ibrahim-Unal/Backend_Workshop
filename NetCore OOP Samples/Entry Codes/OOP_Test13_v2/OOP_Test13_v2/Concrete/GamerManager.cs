using OOP_Test13_v2.Abstract;
using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Concrete
{
    public class GamerManager : IGamerService
    {

        ICheckIdService _checkidservice;
        public GamerManager(ICheckIdService checkIdService)
        {
            _checkidservice = checkIdService;
        }
        public void Add(Gamer p)
        {
            if (_checkidservice.CheckPerson(p))
                Console.WriteLine(p.Name + "Added");
            else
                Console.WriteLine("Not Valid");
        }

        public void Delete(Gamer p)
        {
            if (_checkidservice.CheckPerson(p))
                Console.WriteLine(p.Name + "Deleted");
            else
                Console.WriteLine("Not Valid");
        }

        public void Update(Gamer p)
        {
            if (_checkidservice.CheckPerson(p))
                Console.WriteLine(p.Name + "Updated");
            else
                Console.WriteLine("Not Valid");
        }
    }
}
