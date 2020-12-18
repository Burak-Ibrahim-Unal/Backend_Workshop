using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma12_Ekok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekok alınacak ilk sayı:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ekok alınacak ikinci sayı:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} ile {1} sayılarının Ekoku: {2}",a,b,Ekok_Bul(a,b));
            Console.ReadKey();
        }
        public static int Ekok_Bul(int sayi1, int sayi2)
        {
            int ekok = 1, i = 2;
            while (true)
            {
                if (sayi1 % i == 0 & sayi2 % i == 0)
                {
                    ekok *= i;
                    sayi1 /= i;
                    sayi2 /= i;
                }
                else if (sayi1 % i != 0 & sayi2 % i == 0)
                {
                    ekok *= i;
                    sayi2 /= i;
                }
                else if (sayi1 % i == 0 & sayi2 % i != 0)
                {
                    ekok *= i;
                    sayi1 /= i;
                }
                else
                {
                    i++;
                }
                if (sayi1 == 1 & sayi2 == 1)
                {
                    break;
                }
            }
            return ekok;
        }
    }
}
