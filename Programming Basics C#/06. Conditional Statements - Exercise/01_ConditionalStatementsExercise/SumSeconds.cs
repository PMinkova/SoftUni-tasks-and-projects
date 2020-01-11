using System;

namespace ConditionalStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeFirst = int.Parse(Console.ReadLine());
            int timeSecond = int.Parse(Console.ReadLine());
            int timeThird = int.Parse(Console.ReadLine());

            int timeAllSec = timeFirst + timeSecond + timeThird;
            int timeMin = timeAllSec / 60;
            int sec = timeAllSec % 60;

            if (sec < 10)
            {
                Console.WriteLine("{0}:0{1}", timeMin, sec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", timeMin, sec);
            }
        }
    }
}
