using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_8_Asal_Sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prime numbers...
            
            while (true)
            {
                Console.Write("Enter a number:");
                string number1 = Console.ReadLine();
                if (number1 == "q")
                {
                    break;
                }
                else
                {
                    int number2 = Convert.ToInt32(number1);
                    if (findPrimeNumber(number2.ToString()))
                    {
                        Console.WriteLine("Entered {0} value is prime number.", number2);
                    }
                    else
                    {
                        Console.WriteLine("Entered {0} value is not prime number.", number2);
                    }
                }
            }
        }
        #region Function of Prime number
        public static bool findPrimeNumber(string number)
        {
            if (number == "1")
            {
                return false;
            }
            else if (number == "2")
            {
                return true;
            }
            for (int i = 2; i < Convert.ToInt32(number); i++)
            {
                if (Convert.ToInt32(number) % i == 0)
                {
                    return false;
                }
            }
            return true;
        } 
        #endregion
    }
}




