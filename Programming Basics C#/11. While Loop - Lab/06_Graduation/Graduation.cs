using System;

namespace _06_Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            int counter = 1;
            double gradeSum = 0.0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    gradeSum += grade;
                    counter++;
                }
            }

            double averageGrade = gradeSum / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");           
        }
    }
}
