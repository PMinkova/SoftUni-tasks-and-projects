using System;

namespace _03_StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = "";

            bool isC = true;
            bool isN = true;
            bool isO = true;

            while (input != "End")
            {
                char symbol = char.Parse(input);


                if ('A'<= symbol && symbol <= 'Z' || 'a' <= symbol && symbol <= 'z')
                {
                    if (isC && symbol == 'c')
                    {
                        isC = false;
                    }
                    else if (isO && symbol == 'o')
                    {
                        isO = false;
                    }
                    else if (isN && symbol == 'n')
                    {
                        isN = false;
                    }
                    else
                    {
                        word += symbol;
                    }

                    if (!isN && !isO && !isC)
                    {
                        Console.Write(word + " ");
                        word = String.Empty;
                        isC = true;
                        isO = true;
                        isN = true;
                    }   
                }

                input = Console.ReadLine();
            }


        }
    }
}
