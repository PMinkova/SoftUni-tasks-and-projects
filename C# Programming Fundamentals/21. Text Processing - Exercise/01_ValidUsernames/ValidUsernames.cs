using System;

namespace _01_ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                string currentUserName = usernames[i];
                bool isWithRightLength = IsWithRightLenth(currentUserName);
                bool isContainingOnlyLettersNumbersandOtherSymbols = IsContainingRightSymbols(currentUserName);

                if (isWithRightLength && isContainingOnlyLettersNumbersandOtherSymbols)
                {
                    Console.WriteLine(currentUserName);
                }
            }

        }

        static bool IsContainingRightSymbols(string currentUserName)
        {
            foreach (var letter in currentUserName)
            {
                if (!Char.IsDigit(letter) && !Char.IsLetter(letter) && letter != '-' && letter != '_')
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsWithRightLenth(string currentUserName)
        {
            int length = currentUserName.Length;

            if (3 <= length && length <= 16)
            {
                return true;
            }

            return false;
        }
    }
}
