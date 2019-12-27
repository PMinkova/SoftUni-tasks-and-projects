using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MaximumAndMinimumElement
{
    class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                string query = Console.ReadLine();

                if (query.StartsWith("1"))
                {
                    string[] elements = query.Split();
                    int numberToPush = int.Parse(elements[1]);

                    numbers.Push(numberToPush);
                }
                else if (query == "2" && numbers.Any())
                {
                    numbers.Pop();
                }
                else if (query == "3" && numbers.Any())
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (query == "4" && numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
