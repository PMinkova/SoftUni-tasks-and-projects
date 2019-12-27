using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> addOne = x => x.Select(y => y+=1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y *= 2).ToList();
            Func<List<int>, List<int>> subtractOne = x => x.Select(y => y-=1).ToList();
            Action<List<int>> print = x => Console.WriteLine(String.Join(" ", x));

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "add")
                {
                    numbers = addOne(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtractOne(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                else if (command == "end")
                {
                    break;
                }
            }
        }
    }
}
