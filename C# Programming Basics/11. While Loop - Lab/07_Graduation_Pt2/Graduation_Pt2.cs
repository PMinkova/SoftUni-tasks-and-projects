using System;

namespace _07_Graduation_Pt2
{
    class Graduation_Pt2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sum = 0;
            bool passed = true;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.0)
                    sum += grade;
                else if (passed)
                    passed = false;
                else
                    break;
                grades++;
            }
            if (grades > 12)
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:F2}");
            else
                Console.WriteLine($"{name} has been excluded at {--grades} grade");
        }    
    }
}
