namespace Demo
{
    using System;
    using _02.BinarySearchTree;

    class Program
    {
        static void Main()
        {
            var binarySearchTree = new BinarySearchTree<int>();

            binarySearchTree.Insert(8);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(2);
            binarySearchTree.Insert(6); 
            binarySearchTree.Insert(7); 
            binarySearchTree.Insert(5); 

            var newTree = binarySearchTree.Search(6);
            

            binarySearchTree.EachInOrder(Console.WriteLine);
            newTree.EachInOrder(Console.Write);
        }
    }
}