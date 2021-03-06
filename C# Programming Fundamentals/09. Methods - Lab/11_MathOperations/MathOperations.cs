﻿using System;

namespace _11_MathOperations
{
    class MathOperations
    {
        static double Calculate(int firstNumber, string @operator, int secondNumber)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, @operator, secondNumber);

            Console.WriteLine(result);
        }
    }
}
