using System;

namespace _06_StrongNumber
{
    class StrongNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int factorielNumberSum = 0;

            for (int i = 0; i < number.Length; i++)
            {

                int faktorialNumber = int.Parse(number[i].ToString());
                int faktorial = 1;
                
                for (int j = 1; j <= faktorialNumber; j++)
                {
                    faktorial *= j;
                }

                factorielNumberSum += faktorial;
            }

            bool isStrong = factorielNumberSum == int.Parse(number);

            if (isStrong)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
