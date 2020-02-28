using System;

namespace _05_DigitsLettersAndOther
{
    class DigitsLettersAndOther
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();

            string numbers = "";
            string letters = "";
            string symbols = "";

            foreach (var letter in charArray)
            {
                if (Char.IsDigit(letter))
                {
                    numbers += letter;
                }
                else if (Char.IsLetter(letter))
                {
                    letters += letter;
                }
                else
                {
                    symbols += letter;
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
