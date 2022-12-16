using System;

namespace ConsoleApp1
{
    using System.Collections.Generic;
    using Problem01.List;
    using Problem04.SinglyLinkedList;

    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new SinglyLinkedList<int>();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            Console.WriteLine(String.Join(" ", list));

            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine(String.Join(" ", list));

        }
    }
}
