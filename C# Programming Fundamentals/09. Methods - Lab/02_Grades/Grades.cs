using System;

namespace _02_Grades
{
    class Grades
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGradeAsAWord(grade);
        }

        static void PrintGradeAsAWord(double grade)
        {
            string result = String.Empty;

            if (2.00 <= grade && grade < 3.00)
            {
                result = "Fail";
            }
            else if (3.00 <= grade && grade < 3.50)
            {
                result = "Poor";
            }
            else if (3.50 <= grade && grade < 4.50)
            {
                result = "Good";
            }
            else if (4.50 <= grade && grade < 5.50)
            {
                result = "Very good";
            }
            else if (5.50 <= grade && grade <= 6.00)
            {
                result = "Excellent";
            }

            Console.WriteLine(result);
        }
    }
}
