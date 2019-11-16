using System;

namespace _07_StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 	abv>>>>dasd

            string input = Console.ReadLine();

            string[] splitedInput = input.Split(">");

            string result = splitedInput[0];
            int extraPower = 0;

            for (int i = 1; i < splitedInput.Length; i++)
            {
                result += ">";
                int power = int.Parse(splitedInput[i][0].ToString()) + extraPower;

                if (power > splitedInput[i].Length)
                {
                    extraPower = power - splitedInput[i].Length;
                }
                else
                {
                    result += splitedInput[i].Substring(power);
                }
            }

            Console.WriteLine(result);
        }
    }
}
