using System;
using System.Text;
using System.Linq;

namespace _05_MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string longNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int temp = 0;

            foreach (var ch in longNum.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * num + temp;

                int resultDigit = result % 10;

                sb.Insert(0, resultDigit);
                temp = result / 10;
            }

            if (temp > 0)
            {
                sb.Insert(0, temp);
            }

            string finalResult = sb.ToString().TrimStart('0');

            if (finalResult == string.Empty)
            {
                finalResult = "0";
            }

            Console.WriteLine(finalResult);

        }
    }
}
