using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum of equal-valued terms of fibronacci series up to 4 million?????
            
            ulong a = 1, b = 2, sum = 0, counter = 2;
            sum = a + b;
            while (sum < 4000000)
            {
                if (sum % 2 == 0)
                {
                    counter += sum;
                }
                a = b;
                b = sum;
                sum = a + b;
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
