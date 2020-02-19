using System;
using System.Linq;

namespace P04_Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            var stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(stones);

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
