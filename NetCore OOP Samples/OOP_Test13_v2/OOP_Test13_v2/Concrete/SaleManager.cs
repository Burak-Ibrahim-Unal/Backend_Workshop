using OOP_Test13_v2.Abstract;
using OOP_Test13_v2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Test13_v2.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sell(Gamer g, Campaign c)
        {
            Console.WriteLine("Gamer" + g.Name + " bought the " + c.Name + " with %" + c.Discount);
        }
    }
}
