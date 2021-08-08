using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liste1 = new List<int>();
            List<int> liste2 = new List<int>();
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    liste1.Add(i * j);
                }
            }
            Console.WriteLine(liste1);
            Console.ReadKey();
        }
    }
}
