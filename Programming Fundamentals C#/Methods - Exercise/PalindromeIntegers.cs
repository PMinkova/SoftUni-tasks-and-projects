﻿using System;
using System.Linq;

namespace _10_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                bool isPalindromNumber = CheckIfTheNumberIsPalindrom(number);

                Console.WriteLine(isPalindromNumber.ToString().ToLower());
                number = Console.ReadLine();
            }
        }

        static bool CheckIfTheNumberIsPalindrom(string number)
        {
            bool isPalindrome = true;

            //int[] digits = number
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] != number[number.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
