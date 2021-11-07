using System;

namespace _17_FriendlyNumbers
{
    class Program
    {

        // Amicable Number Algorithm 
        // https://en.wikipedia.org/wiki/Amicable_numbers
        /*
        The smallest pair of amicable numbers is (220, 284). They are amicable because the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110,
        of which the sum is 284; and the proper divisors of 284 are 1, 2, 4, 71 and 142, 
        of which the sum is 220.
        */

        static void Main(string[] args)
        {
            calculateAmicableNumber(220, 284);
            Console.ReadLine();
        }

        private static int calculateDivisorSum(int num)
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
