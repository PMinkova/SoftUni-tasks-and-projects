using System;
using System.Linq;

namespace _02_EasterGifts
{
    class EasterGifts
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine().Split();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] commandParts = input.Split();

                string command = commandParts[0];
                string gift = commandParts[1];

                switch (command)
                {
                    case "OutOfStock":
                        ChangeGiftsValue(gift, gifts);
                        break;
                    case "Required":
                        int index = int.Parse(commandParts[2]);
                        ReplaceAtGivenIndex(gift, index, gifts);
                        break;
                    case "JustInCase":
                        gifts[gifts.Length - 1] = gift;
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", gifts.Where(x => x != "None")));
        }

        static void ReplaceAtGivenIndex(string gift, int index, string[] gifts)
        {
            if (0 <= index && index < gifts.Length)
            {
                gifts[index] = gift;
            }
        }

        static void ChangeGiftsValue(string gift, string[] gifts)
        {
            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] == gift)
                {
                    gifts[i] = "None";
                }
            }
        }
    }
}
