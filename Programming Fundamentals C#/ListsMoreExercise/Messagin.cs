using System;
using System.Linq;
using System.Collections.Generic;


namespace _01_Messaging
{
    class Messagin
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();

            string text = Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<char> digits = numbers[i].ToList();

                int index = 0;

                for (int j = 0; j < digits.Count; j++)
                {
                    index += int.Parse(digits[j].ToString());
                }

                int countIndex = 0;

                for (int k = 0; k < index; k++)
                {
                    countIndex++;

                    if (countIndex == text.Length)
                    {
                        countIndex = 0;
                    }
                }

                char currentChar = text[countIndex];

                Console.Write(currentChar);

                string newMessage = text.Remove(countIndex, 1);
                text = newMessage;
            }

            Console.WriteLine();
        }
    }
}
