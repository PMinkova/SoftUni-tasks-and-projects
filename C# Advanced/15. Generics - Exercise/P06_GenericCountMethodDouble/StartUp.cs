using System;

namespace P06_GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                box.Values.Add(input);
            }

            var value = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CountElementsGraterThanValue(value));
        }
    }
}
