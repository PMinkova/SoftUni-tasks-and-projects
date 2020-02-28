using System;

namespace _11_MultiplicationTableSecondVersion
{
    class MultiplicationTableSecondVersion
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multyplier = int.Parse(Console.ReadLine());

            for (int i = multyplier; i <= 10; i++)
            {
                Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
            }
            if (multyplier > 10)
            {
                Console.WriteLine($"{theInteger} X {multyplier} = {theInteger * multyplier}");
            }
        }
    }
}
