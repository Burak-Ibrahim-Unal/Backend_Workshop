using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_10_Mukemmel_Sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-1000 arasındaki sayılar mükemmel mi değil mi kontrol et...
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                object number1 = (Console.ReadLine());
                if (number1.ToString() == "q")
                {
                    break;
                }
                //if (number1.ToString() == "q")
                //{

                //}
                else
                {
                    Muk_Sayi(Convert.ToInt32(number1));
                }
            }

        }
        public static int Muk_Sayi(int number)
        {
            int sum = 0;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += number / i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("Entered {0} number is perfect number.", number);
            }
            else
            {
                Console.WriteLine("Entered {0} number is not perfect number.", number);
            }
            return number;
        }
    }
}
