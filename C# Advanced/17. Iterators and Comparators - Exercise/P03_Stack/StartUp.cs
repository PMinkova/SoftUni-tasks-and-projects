using System;
using System.Linq;

namespace P03_Stack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input.Contains("Push"))
                {
                    var elements = input.Replace("Push ", "").Split(", ");

                    foreach (var element in elements)
                    {
                        stack.Push(element);
                    }
                }
                else if (input == "Pop")
                {
                    stack.Pop();
                }
            }

            stack.PrintAllElements(stack);
            stack.PrintAllElements(stack);
        }
    }
}
