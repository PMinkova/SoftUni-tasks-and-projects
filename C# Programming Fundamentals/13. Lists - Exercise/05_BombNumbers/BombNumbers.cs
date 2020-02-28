using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] bombAndPower = Console.ReadLine().Split();

            int bombNumber = int.Parse(bombAndPower[0]);
            int power = int.Parse(bombAndPower[1]);

            while (numbers.Contains(bombNumber))
            {
                if (numbers.IndexOf(bombNumber) - power > 0) 
                {
                    for (int i = 0; i < power; i++)
                    {
                        numbers.RemoveAt(numbers.IndexOf(bombNumber) - 1);
                    }
                }
                else
                {
                    for (int i = 0; i < numbers.IndexOf(bombNumber); i++)
                    {
                        numbers.RemoveAt(numbers.IndexOf(bombNumber) - 1);
                        i--;
                    }
                }


                if (numbers.IndexOf(bombNumber) + power < numbers.Count)
                {
                    for (int i = 0; i < power; i++)
                    {
                        numbers.RemoveAt(numbers.IndexOf(bombNumber) + 1);
                    }
                }
                else
                {
                    for (int i = numbers.IndexOf(bombNumber); i < numbers.Count; i++)
                    {
                        numbers.RemoveAt(i + 1);
                    }
                }

                numbers.RemoveAt(numbers.IndexOf(bombNumber));
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
