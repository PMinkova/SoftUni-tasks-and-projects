using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "find")
            {
                int counter = 0;
                char[] message = input.ToCharArray();

                for (int i = 0; i < message.Length; i++)
                {
                    if (counter == keys.Length)
                    {
                        counter = 0;
                    }

                    message[i] -= (char)keys[counter];

                    counter++;
                }

                string result = "";

                for (int i = 0; i < message.Length; i++)
                {
                    result += message[i];
                }

                string[] arr = result.Split('&');
                string treasure = arr[1];
                int startIndex = result.IndexOf('<');
                int finalIndex = result.IndexOf('>');
                int length = finalIndex - startIndex;
                string coordinates = result.Substring(startIndex + 1, length - 1);

                Console.WriteLine($"Found {treasure} at {coordinates}");

                input = Console.ReadLine();
            }

        }
    }
}
