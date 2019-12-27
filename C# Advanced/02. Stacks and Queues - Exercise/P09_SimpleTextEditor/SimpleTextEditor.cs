using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P09_SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            int commandsCount = int.Parse(Console.ReadLine());
            Stack<string> undoneText = new Stack<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                
                string command = commandArgs[0];

                switch (command)
                {
                    case "1":
                        string someString = commandArgs[1];
                        undoneText.Push(text.ToString());
                        text.Append(someString);
                        break;
                    case "2":
                        int count = int.Parse(commandArgs[1]);
                        int startindex = text.Length - count;
                        undoneText.Push(text.ToString());
                        text = text.Remove(startindex, count);
                        break;
                    case "3":
                        int index = int.Parse(commandArgs[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text = new StringBuilder();
                        text.Append(undoneText.Pop());
                        break;
                }
            }
        }
    }
}
