using System;
using System.Collections.Generic;
using System.Linq;


namespace P08_BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> openParenthesis = new Stack<char>();
            bool areBalanced = true;
     
            for (int i = 0; i < input.Length; i++)
            {
                char currentParenthesis = input[i];

                if (currentParenthesis == '(' || currentParenthesis == '[' || currentParenthesis == '{')
                {
                    openParenthesis.Push(currentParenthesis);
                }
                else if ((currentParenthesis == ')' || currentParenthesis == ']' || currentParenthesis == '}') && openParenthesis.Any())
                {
                    bool areEqual = openParenthesis.Peek() == '(' && currentParenthesis == ')' ||
                                    openParenthesis.Peek() == '{' && currentParenthesis == '}' ||
                                    openParenthesis.Peek() == '[' && currentParenthesis == ']';

                    if (areEqual)
                    {
                        openParenthesis.Pop();
                    }
                    else
                    {
                        areBalanced = false;
                        break;
                    }
                }
                else
                {
                    areBalanced = false;
                    break;
                }
            }

            if (!areBalanced)
            {
                Console.WriteLine("NO");
            }
            else if (!openParenthesis.Any())
            {
                Console.WriteLine("YES");
            }
        }
    }
}