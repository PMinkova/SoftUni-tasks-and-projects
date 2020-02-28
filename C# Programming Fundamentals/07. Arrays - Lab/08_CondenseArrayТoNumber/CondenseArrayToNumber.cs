using System;
using System.Linq;

namespace _08_CondenseArrayТoNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

           
                int result = 0;

            while (nums.Length > 1)
            {

                int[] condensed = new int[nums.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }

                nums = condensed;
                result = condensed[0];

            }

            if (nums.Length == 1)
            {
                result = nums[0];
            }

            Console.WriteLine(result);
        }
    }
}
