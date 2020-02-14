using System;

namespace P09_CustomLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var customList = new DoublyLinkedList<int>();

            customList.AddFirst(1);
            customList.AddFirst(2);
            customList.AddFirst(3);

            Console.WriteLine(String.Join(" ", customList));
        }
    }
}
