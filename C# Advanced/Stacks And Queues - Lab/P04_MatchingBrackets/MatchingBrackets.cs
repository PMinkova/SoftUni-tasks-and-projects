using System;
using System.Collections.Generic;
using System.Linq;


namespace P04_MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] expression = input.ToArray();

            Stack<int> bracketsIndex = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char currentSymbol = expression[i];

                if (currentSymbol == '(')
                {
                    bracketsIndex.Push(i);
                }
                else if (currentSymbol == ')')
                {
                    int startIndex = bracketsIndex.Pop();
                    string result = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
