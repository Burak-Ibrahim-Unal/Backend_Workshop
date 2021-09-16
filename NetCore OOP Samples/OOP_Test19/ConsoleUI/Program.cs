using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var cm = new CarManager(new EfCarDal());
            var Results = cm.GetCarDetails();
            if (cm.GetCarDetails().Success)
            {
                foreach (var car in Results.Data)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}", car.Id , car.Model , car.BrandName ,car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(Results.Messages);
            }
        }
    }
}
