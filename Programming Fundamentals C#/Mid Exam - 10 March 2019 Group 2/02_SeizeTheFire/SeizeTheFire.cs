using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_SeizeTheFire
{
    class SeizeTheFire
    {
        static void Main(string[] args)
        {
            string[] fireCells = Console.ReadLine()
                .Split("#", StringSplitOptions.RemoveEmptyEntries);

            int water = int.Parse(Console.ReadLine());

            double totalEffort = 0;
            int totalFire = 0;

            Console.WriteLine("Cells:");

            for (int i = 0; i < fireCells.Length; i++)
            {
                string[] currentCell = fireCells[i].Split(" = ", StringSplitOptions.RemoveEmptyEntries);

                string typeOfFire = currentCell[0];
                int valueOfCell = int.Parse(currentCell[1]);

                bool isValid = false;

                if (typeOfFire == "High")
                {
                    if (81 <= valueOfCell && valueOfCell <= 125)
                    {
                        isValid = true;
                    }
                }
                else if (typeOfFire == "Medium")
                {
                    if (51 <= valueOfCell && valueOfCell <= 80)
                    {
                        isValid = true;
                    }
                }
                else if (typeOfFire == "Low")
                {
                    if (1 <= valueOfCell && valueOfCell <= 50)
                    {
                        isValid = true;
                    }
                }

                if (isValid && water - valueOfCell >=0)
                {
                    water -= valueOfCell;
                    double currentEffort = 0.25 * valueOfCell;
                    totalFire += valueOfCell;
                    totalEffort += currentEffort;

                    Console.WriteLine($"- {valueOfCell}");
                }                
            }

            Console.WriteLine($"Effort: {totalEffort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
