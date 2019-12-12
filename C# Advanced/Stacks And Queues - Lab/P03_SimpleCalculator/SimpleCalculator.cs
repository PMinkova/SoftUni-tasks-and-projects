using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P03_SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 2 + 5 + 10 - 2 - 1
            string[] expression = input.Split();
            Stack<string> stack = new Stack<string>(expression.Reverse()); // 1 - 2 - 10 + 5 + 2

            while (stack.Count > 1)
            {
                int leftOperand = int.Parse(stack.Pop());
                string @operator = stack.Pop();
                int rightOperand = int.Parse(stack.Pop());

                switch (@operator)
                {
                    case "+":
                        stack.Push((leftOperand + rightOperand).ToString());
                        break;
                    case "-":
                        stack.Push((leftOperand - rightOperand).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
