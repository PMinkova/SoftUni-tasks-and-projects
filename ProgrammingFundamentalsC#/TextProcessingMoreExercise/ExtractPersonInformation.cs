using System;
using System.Linq;

namespace _01_ExtractPersonInformation
{
    class ExtractPersonInformation
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string text = Console.ReadLine();

                int indexOfAtSign = text.IndexOf("@");
                int indexOfPipe = text.IndexOf("|");
                int nameLength = indexOfPipe - indexOfAtSign - 1;

                int indexOfNumberSign = text.IndexOf("#");
                int indexOfStarSign = text.IndexOf("*");
                int ageLength = indexOfStarSign - indexOfNumberSign - 1;

                string name = text.Substring(indexOfAtSign + 1, nameLength);
                string age = text.Substring(indexOfNumberSign + 1, ageLength);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
