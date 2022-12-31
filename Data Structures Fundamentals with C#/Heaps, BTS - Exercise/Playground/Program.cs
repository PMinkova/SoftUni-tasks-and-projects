using System;
using _03.MinHeap;
using _04.CookiesProblem;

namespace Playground
{
    using System.Runtime.CompilerServices;
    using _02.BinarySearchTree;

    class Program
    {
        static void Main(string[] args)
        {
            // Arrange
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            bst.Insert(10);

            bst.Delete(10);

            bst.EachInOrder(Console.WriteLine);
        }
    }
}
