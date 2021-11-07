using System;

namespace _17_FriendlyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateAmicableNumber(220, 284);
            Console.ReadLine();
        }

        static int calculateDivisorSum(int num)
        {
            int numberSum = 1;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    numberSum += num / i;
                }
            }
            return numberSum;
        }

        private static void calculateAmicableNumber(int num1, int num2)
        {
            if (calculateDivisorSum(num1) == num2 && calculateDivisorSum(num2) == num1)
            {
                Console.WriteLine($" {num1} and {num2} are amicable numbers");
            }
            else
            {
                Console.WriteLine($" {num1} and {num2} numbers not amicable numbers");
            }
        }
    }
}
