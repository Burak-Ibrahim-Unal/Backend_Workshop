using OOP_Test13_v2.Abstract;
using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign c)
        {
            Console.WriteLine(c.Name + " campaign which has id number " + c.Id + " added");
        }

        public void Delete(Campaign c)
        {
            Console.WriteLine(c.Name + " campaign which has id number " + c.Id + " deleted");
        }

        public void Update(Campaign c)
        {
            Console.WriteLine(c.Name + " campaign which has id number " + c.Id + " updated");
        }
    }
}
