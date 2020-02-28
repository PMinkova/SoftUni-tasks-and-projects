using System;
using System.Linq;

namespace _02_FriendListMaintenance
{
    class FriendListMaintenance
    {
        static void Main(string[] args)
        {
            string[] friendList = Console.ReadLine().Split(", ");

            string input = Console.ReadLine();
            string name = String.Empty;
            int index = 0;
            int countOfBlacklisted = 0;
            int countOfLostNames = 0;

            while (input != "Report")
            {
                string[] commandParts = input.Split();

                string command = commandParts[0];            

                if (command == "Blacklist")
                {
                    name = commandParts[1];

                    if (!friendList.Contains(name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    else
                    {
                        for (int i = 0; i < friendList.Length; i++)
                        {
                            if (friendList[i] == name)
                            {
                                friendList[i] = "Blacklisted";
                                Console.WriteLine($"{name} was blacklisted.");
                                countOfBlacklisted++;
                            }
                        }
                    }
                }
                else if (command == "Error")
                {
                    index = int.Parse(commandParts[1]);

                    if (friendList[index] != "Blacklisted" && friendList[index] != "Lost")
                    {
                        Console.WriteLine($"{friendList[index]} was lost due to an error.");
                        friendList[index] = "Lost";
                        countOfLostNames++;
                    }
                }
                else if (command == "Change")
                {
                    index = int.Parse(commandParts[1]);
                    string newName = commandParts[2];

                    if (0 <= index && index < friendList.Length)
                    {
                        string oldName = friendList[index];

                        friendList[index] = newName;
                        Console.WriteLine($"{oldName} changed his username to {newName}.");
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {countOfBlacklisted}");
            Console.WriteLine($"Lost names: {countOfLostNames}");
            Console.WriteLine(String.Join(" ", friendList));
        }
    }
}
