using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_14_listOfPisagor
{
    class Program
    {
        static void Main(string[] args)
        {
            listOfPisagor();
        }
        public static double listOfPisagor()
        {
            double c;
            for (double i = 1; i < 101; i++)
            {
                for (double j = 1; j < 101; j++)
                {
                    c = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    if (c == Convert.ToInt32(c))
                    {
                        Console.WriteLine("{0},{1},{2}", i, j, c);
                    }

                }
            }
            Console.ReadKey();
            return 0;
        }
    }
}
