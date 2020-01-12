using System;

namespace _04_TribonacciSequence
{
    class TribonacciSequence
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTribonacciSequence(number); 
        }

        static void PrintTribonacciSequence(int length)
        {
            int[] nums = new int[length];

            nums[0] = 1;

            if (length >= 2)
            {
                nums[1] = 1;
            }

            if (length >= 3)
            {
                nums[2] = 2;
            }
            
            for (int i = 3; i < length; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2] + nums[i - 3];
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}