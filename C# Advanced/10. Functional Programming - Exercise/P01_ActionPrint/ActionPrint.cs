using System;
using System.Linq;

namespace P01_ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            Action<string> printName = x => Console.WriteLine(x);

                Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(printName);
                
        }
    }
}
