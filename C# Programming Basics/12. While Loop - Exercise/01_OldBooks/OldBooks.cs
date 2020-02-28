using System;

namespace _01_OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheBook = Console.ReadLine();
            string input = "";
            int capacity = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter < capacity)
            {
                input = Console.ReadLine();
                
                if (input == nameOfTheBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
            }
            if (counter >= capacity)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            
        }
    }
}
