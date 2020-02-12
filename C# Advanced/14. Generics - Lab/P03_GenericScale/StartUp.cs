using System;

namespace GenericScale
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var dh = new EqualityScale<int>(5, 5);

            Console.WriteLine(dh.AreEqual());
        }
    }
}
