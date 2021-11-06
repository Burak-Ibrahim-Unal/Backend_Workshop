using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());
            foreach (var car in carManager.GetAllCars())
            {
                Console.WriteLine("Car Price:{0}", car.DailyPrice);
            }
        }
    }
}
