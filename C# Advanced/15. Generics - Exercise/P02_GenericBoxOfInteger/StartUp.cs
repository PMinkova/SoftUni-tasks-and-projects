using System;

namespace P02_GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());

                var box = new Box<int>(input);

                Console.WriteLine(box);
            }
        }
    }
}
