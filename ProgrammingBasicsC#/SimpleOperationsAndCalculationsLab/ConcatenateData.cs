using System;

namespace _2.ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firtsName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firtsName,lastName, age, town);
        }
    }
}
