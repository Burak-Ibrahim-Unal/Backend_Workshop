using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition of numbers that are a multiple of 3 or 5 between 0-100
            //Version 1.
            int sum = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //    else if (i % 15 == 0)
            //    {
            //        sum -= i;
            //    }
            //}
            //Version 2.
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            //for (int i = 0; i < 1000; i++)
            //{
            //    sum = i % 3 == 0 || i % 5 == 0 ? sum += i : sum += 0 ;
            //}
            Console.WriteLine("Addition of numbers that are a multiple of 3 or 5 :{0}", sum);
            Console.ReadKey();
        }
    }
}
