namespace Demo
{
    using System;
    using Microsoft.VisualBasic;
    using Tree;

    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[]{"7 19", "7 21", "7 14", "19 1", "19 12", "19 31", "14 23", "14 6"};

            var integerTreeFactory = new IntegerTreeFactory();

            var tree = integerTreeFactory.CreateTreeFromStrings(input);
            var result = tree.GetSubtreesWithGivenSum(43);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
