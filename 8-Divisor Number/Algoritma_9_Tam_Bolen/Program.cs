using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_9_Divisor_Number
{
    class Program
    {
        //divisor number
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
                if (Console.ReadLine() == "q")
                {
                    break;
                }
                else
                {
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Divisor Numbers:{0}",Divisor_Number(number1));
                }
            }
        }
        public static List<int> Divisor_Number(int number)
        {
            List<int> mylist = new List<int>();
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    mylist.Add(i);
                }
            }
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
            return mylist;
        }
    }
}
