using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armstrong Sayısı... 1634=1^4 + 6^4 + 3^4 + 4^4 gibi...
            double sum = 0;
            Console.WriteLine("Bir sayı giriniz:");
            string num1 = Console.ReadLine();
            double num2=Convert.ToDouble(num1);
            for (int i = 0; i < num1.Length; i++)
            {
                double sayi3 = Convert.ToDouble(num1[i].ToString());
                sum += Math.Pow(sayi3, (num1.Length));
            }
            if (sum == num2)
            {
                Console.WriteLine("This is an Armstrong number...");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong number...");
            }
            Console.ReadKey();
        }
    }
}
