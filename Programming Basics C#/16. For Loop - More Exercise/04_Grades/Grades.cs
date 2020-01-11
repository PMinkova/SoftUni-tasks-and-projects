using System;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double betweenTwoAndThree = 0;
            double betweenthreeAndFor = 0;
            double betweenFourAndFive = 0;
            double betweenfiveAndSix = 0;
            double totalGrade = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (2 <= grade && grade < 3)
                {
                    betweenTwoAndThree++;
                }
                else if (3 <= grade && grade < 4)
                {
                    betweenthreeAndFor++;
                }
                else if (4 <= grade && grade < 5)
                {
                    betweenFourAndFive++;
                }
                else if (grade >= 5)
                {
                    betweenfiveAndSix++;
                }

                totalGrade += grade;
            }
            double avgGrade = totalGrade / studentsCount;

            betweenfiveAndSix = betweenfiveAndSix / studentsCount * 100;
            betweenFourAndFive = betweenFourAndFive / studentsCount * 100;
            betweenthreeAndFor = betweenthreeAndFor / studentsCount * 100;
            betweenTwoAndThree = betweenTwoAndThree / studentsCount * 100;

            Console.WriteLine($"Top students: {betweenfiveAndSix:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {betweenFourAndFive:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {betweenthreeAndFor:f2}%");
            Console.WriteLine($"Fail: {betweenTwoAndThree:f2}%");
            Console.WriteLine($"Average: {avgGrade:f2}");
        }
    }
}
