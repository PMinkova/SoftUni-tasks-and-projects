using System;

namespace _01_PoolDay
{
    class PoolDay
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double wordMaxValue = int.MinValue;
            string mostPowerFullWord = String.Empty;
            bool isVowel = false;
            
            while (input != "End of words")
            {
                double wordValue = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    char symbol = input[i];
                    wordValue += symbol;

                    if (i == 0)
                    {
                        if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y' ||
                            symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U' || symbol == 'Y')
                        {
                            isVowel = true;
                        }                      
                    }
                }

                if (isVowel)
                {
                    wordValue *= input.Length;
                }
                else
                {
                    wordValue = Math.Floor(wordValue / (int)input.Length);
                }

                if (wordValue > wordMaxValue)
                {
                    wordMaxValue = wordValue;
                    mostPowerFullWord = input;
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {mostPowerFullWord} - {wordMaxValue}");
        }
    }
}
