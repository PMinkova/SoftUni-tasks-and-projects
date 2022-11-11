using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main()
        {
            try
            {
                var length = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                var box = new Box(length, width, height);

                Console.WriteLine(box);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
