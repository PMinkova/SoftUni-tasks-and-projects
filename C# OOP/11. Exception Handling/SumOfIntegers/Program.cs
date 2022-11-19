namespace SumOfIntegers
{
    using System;

    public class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ");

            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentElement = input[i];

                try
                {
                    var number = int.Parse(currentElement);
                    sum += number;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{currentElement}' is out of range!");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{currentElement}' is in wrong format!");
                }
                finally
                {
                    Console.WriteLine($"Element '{currentElement}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
