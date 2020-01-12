using System;
using System.Linq;

namespace _02_Santa_sList
{
    class SantasList
    {
        static void Main(string[] args)
        {
            string[] list = Console.ReadLine().Split("&");

            string input = Console.ReadLine();

            while (input != "Finished!")
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                if (command == "Bad")
                {
                    string kidName = commandParts[1];

                    if (!list.Contains(kidName))
                    {
                        int newListCount = list.Length + 1;
                        string[] newList = new string[newListCount];
                        newList[0] = kidName;

                        for (int i = 1; i < newList.Length; i++)
                        {
                            newList[i] = list[i - 1];
                        }

                        list = newList;
                    }
                }
                else if (command == "Good" && list.Contains(commandParts[1]))
                {
                    int anotherNewListlentgh = list.Length - 1;
                    string kidName = commandParts[1];
                    string[] anotherNewList = new string[anotherNewListlentgh];
                    bool isRemoved = false;

                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        if (!isRemoved)
                        {
                            anotherNewList[i] = list[i];
                        }

                        if (anotherNewList[i] == kidName || isRemoved)
                        {
                            anotherNewList[i] = list[i + 1];
                            isRemoved = true;
                        }
                    }

                    list = anotherNewList;
                }
                else if (command == "Rename" && list.Contains(commandParts[1]))
                {
                    string oldName = commandParts[1];
                    string newName = commandParts[2];

                    for (int i = 0; i < list.Length; i++)
                    {
                        if (list[i] == oldName)
                        {
                            list[i] = newName;
                        }
                    }
                }

                if (command == "Rearrange" && list.Contains(commandParts[1]))
                {
                    string kidName = commandParts[1];
                    string[] lastNewList = new string[list.Length];
                    bool isRemoved = false;

                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        if (!isRemoved)
                        {
                            lastNewList[i] = list[i];
                        }

                        if (list[i] == kidName || isRemoved)
                        {
                            lastNewList[i] = list[i + 1];
                            isRemoved = true;
                        }
                    }

                    lastNewList[list.Length - 1] = kidName;
                    list = lastNewList;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}
