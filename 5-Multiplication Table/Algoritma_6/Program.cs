using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Çarpım Tablosu...
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}",i,j,i*j);
                    if (j==10)
                    {
                        Console.WriteLine("\n#########################");
                    }
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
