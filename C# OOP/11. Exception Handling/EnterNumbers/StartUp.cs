using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterNumbers
{
    public class StartUp
    {
        static void Main()
        {

            List<int> numbers = new List<int>();


            while (numbers.Count != 10)
            {
                int startNumber = 1;
                int endNumber = 100;

                try
                {
                    ReadNumber(startNumber, endNumber, numbers);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (ArgumentException ae) // or ArgumentOutOfRangeException
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }

        public static void ReadNumber(int startNumber, int endNumber, List<int> numbers)
        {
            var isInteger = int.TryParse(Console.ReadLine(), out int currentNumber);

            if (!isInteger)
            {
                throw new FormatException("Invalid Number!");
            }

            if (numbers.Any())
            {
                startNumber = numbers[numbers.Count - 1];
                endNumber = startNumber + 2;
            }

            if (currentNumber <= startNumber || currentNumber >= endNumber)
            {
                throw new ArgumentException($"Your number is not in range {startNumber} - 100!");
            }

            numbers.Add(currentNumber);
        }
    }
}