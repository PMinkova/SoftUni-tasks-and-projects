using System;

namespace _02_CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            string first = array[0];
            string second = array[1];

            int result = MultiplyAndSum(first, second);

            Console.WriteLine(result);
        }

        private static int MultiplyAndSum(string first, string second)
        {
            char[] firstCharArray = first.ToCharArray();
            char[] secondCharArray = second.ToCharArray();

            int result = 0;

            if (firstCharArray.Length <= secondCharArray.Length)
            {
                for (int i = 0; i < firstCharArray.Length; i++)
                {
                    char firstChar = firstCharArray[i];
                    char secondChar = secondCharArray[i];

                    result += firstChar * secondChar;
                }

                int diff = secondCharArray.Length - firstCharArray.Length;

                for (int i = 0; i < diff; i++)
                {
                    result += secondCharArray[secondCharArray.Length - i - 1];
                }
                
            }
            else
            {
                for (int i = 0; i < secondCharArray.Length; i++)
                {
                    char firstChar = firstCharArray[i];
                    char secondChar = secondCharArray[i];

                    result += firstChar * secondChar;
                }

                int diff = firstCharArray.Length - secondCharArray.Length;

                for (int i = 0; i < diff; i++)
                {
                    result += firstCharArray[firstCharArray.Length - i - 1];
                }
            }

            return result;
        }
    }
}
