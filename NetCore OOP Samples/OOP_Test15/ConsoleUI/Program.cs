using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager cm = new CarManager(new EFCarDal());
            foreach (var car in cm.GetAll())
            {
                Console.WriteLine("{0} id with price {1} ", car.Id, car.Price);
            }
        }
    }
}
