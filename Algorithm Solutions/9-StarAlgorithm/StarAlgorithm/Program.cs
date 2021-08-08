using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StarAlgorithm
{
    class Program
    {
        //Star Algorithm
        static void Main(string[] args)
        {
            int height = 100;
            for (int i = 1; i <= height; i += 2)
            {
                for (int j = 0; j < (height - 1) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                height-=2;
            }

        }
    }
}
