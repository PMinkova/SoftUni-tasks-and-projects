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

            Stack<char> openingBrackets = new Stack<char>();

            bool areBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                char currentParenthesis = input[i];

                bool hasSameClosingBracket = openingBrackets.Peek() == '(' && currentParenthesis == ')' ||
                               openingBrackets.Peek() == '{' && currentParenthesis == '}' ||
                               openingBrackets.Peek() == '[' && currentParenthesis == ']';

                bool isOpeningBracket =
                    currentParenthesis == '(' || currentParenthesis == '[' || currentParenthesis == '{';

                if (isOpeningBracket)
                {
                    openingBrackets.Push(currentParenthesis);
                }
                else if (hasSameClosingBracket && openingBrackets.Any())
                {
                    openingBrackets.Pop();
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
            else if (!openingBrackets.Any())
            {
                Console.WriteLine("YES");
            }
        }
    }
}
