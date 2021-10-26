using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        public static string StringChallenge(string str)
        {

            /* 
             Return length of String "str" after changes letter.
            If str is abcabc,we check 0 and 1 index 
            and if they are same we continue to check next letters
            and if they are not same we will replace with another letter

            For example str="abcabc"
            a is not equal b,so we will remove a,b and put c... Then abcabc return ccabc
            we check first letters again.if c is equal c then we will check next letters
            our string is ccabc and we are checking 1-2 index letters
            c is not equal a,so we will remove c and a and replace b.Then our string turns cbbc
            c is not equal with b and out string turns abc then
            a is not equal with b then our string turns cc
            And Finally cc length is 2...

            Another Example str = "aaaa"
            So all letters are same and length is 4
             
             */
            //abcabc
            List<char> result2 = str.ToList();
            List<char> myCharArray = new List<char>() { 'a', 'b', 'c' };
            for (int i = 0; i < result2.Count; i++)
            {
                if (i + 1 < result2.Count)
                {
                    if (result2[i] == result2[i + 1])
                    {
                        continue;
                    }
                    else
                    {
                        List<char> tempCharArray = new List<char>() { result2[i], result2[i + 1] };
                        List<char> tempStringArray= myCharArray.Except(tempCharArray).ToList();
                        char notIncluded = tempStringArray[0];
                        result2.RemoveAt(i);
                        result2.RemoveAt(i);
                        result2.Insert(i,notIncluded);
                        i=-1;
                       
                    }
                }
            }
            return result2.Count.ToString();

        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}
