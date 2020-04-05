using System;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            var myStack = new CustomStack();
            var items = new string[3] {"1", "2", "3"};
            myStack.AddRange(items);

            Console.WriteLine(myStack.IsEmpty());
            Console.WriteLine(String.Join(" ", myStack.Reverse()));
        }
    }
}
