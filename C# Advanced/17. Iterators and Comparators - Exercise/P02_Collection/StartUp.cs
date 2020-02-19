using System;
using System.Collections.Generic;

namespace P02_Collection
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            var list = new List<string>();

            if (input.Length > 1)
            {
                for (int i = 1; i < input.Length; i++)
                {
                    var currentElement = input[i];
                    list.Add(currentElement);
                }
            }

            var iterator = new ListyIterator<String>(list);

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command == "Move")
                {
                    Console.WriteLine(iterator.Move());
                }
                else if (command == "Print")
                {
                    iterator.Print();
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(iterator.HasNext());
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", list));
                }
            }
        }
    }
}
