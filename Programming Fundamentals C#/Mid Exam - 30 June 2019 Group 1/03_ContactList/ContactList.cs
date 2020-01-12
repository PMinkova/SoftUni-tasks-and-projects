using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_ContactList
{
    class ContactList
    {
        static void Main(string[] args)
        {
            List<string> contactList = Console.ReadLine()
                .Split().ToList();

            string input = Console.ReadLine();
            int index = 0;

            while (true)
            {
                string[] commandParts = input.Split();
                string command = commandParts[0];

                if (command == "Add")
                {
                    string contact = commandParts[1];
                    index = int.Parse(commandParts[2]);
                    bool isIndexValid = CheckIsIndexValid(contactList, index);

                    if (!contactList.Contains(contact) && isIndexValid)
                    {
                        contactList.Add(contact);
                    }
                    else if (isIndexValid)
                    {
                        contactList.Insert(index, contact);
                    }
                }
                else if (command == "Remove")
                {
                    index = int.Parse(commandParts[1]);
                    bool isIndexValid = CheckIsIndexValid(contactList, index);
                    if (isIndexValid)
                    {
                        contactList.RemoveAt(index);
                    }
                }
                else if (command == "Export")
                {
                    int startingIndex = int.Parse(commandParts[1]);
                    int count = int.Parse(commandParts[2]);

                    List<string> currentList = new List<string>();
                    if (startingIndex + count > contactList.Count - 1)
                    {
                        for (int i = startingIndex; i < contactList.Count; i++)
                        {
                            currentList.Add(contactList[i]);
                        }
                    }
                    else
                    {
                        int endIndex = startingIndex + count;

                        for (int i = startingIndex; i < endIndex; i++)
                        {
                            currentList.Add(contactList[i]);
                        }
                    }

                    Console.WriteLine(String.Join(" ", currentList));
                }
                else if (command == "Print")
                {
                    if (commandParts.Contains("Reversed"))
                    {
                        contactList.Reverse();
                    }
                    Console.WriteLine($"Contacts: {String.Join(" ", contactList)}");
                    break;
                }

                input = Console.ReadLine();
            }
        }

        static bool CheckIsIndexValid(List<string> contactList, int index)
        {
            if (0 <= index && index < contactList.Count)
            {
                return true;
            }
            return false;
        }
    }
}
