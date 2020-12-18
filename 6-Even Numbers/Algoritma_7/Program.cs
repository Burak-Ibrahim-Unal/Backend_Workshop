using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // List and display even numbers 1-100...
            List<int> mylist = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                if (i%2==0)
                {
                    mylist.Add(i);
                }
            }
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
