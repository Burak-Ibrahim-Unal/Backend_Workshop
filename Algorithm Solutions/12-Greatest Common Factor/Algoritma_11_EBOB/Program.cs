using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma_11_EBOB
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 sayının ebobunu bulan program...
            while (true)
            {
                Console.WriteLine("Lütfen ebob bulunacak ilk sayıyı giriniz:");
                int a =Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Lütfen ebob bulunacak ikinci sayıyı giriniz:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} ile {1} sayılarının Ebobu: {2}",a,b, Ebob_Bul(a, b));
            }
        }
        public static int Ebob_Bul(int sayi1, int sayi2)
        {
            int i = 1, Ebob = 1;
            while (i <= sayi1 & i <= sayi2)
            {
                if (sayi1 % i == 0 & sayi2 % i == 0)
                {
                    Ebob = i;
                }
                i++;
            }
            return Ebob;
        }
    }
}
