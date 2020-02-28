using System;

namespace _09_OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourComing = int.Parse(Console.ReadLine());
            int minutesComing = int.Parse(Console.ReadLine());

            int timeExamInMinutes = hourExam * 60 + minutesExam;
            int timeComingInMinutes = hourComing * 60 + minutesComing;
            int hourLeft = 0;
            int minutesLeft = 0;

            if (timeComingInMinutes > timeExamInMinutes)
            {
                Console.WriteLine("Late");
            }
            else if ((timeExamInMinutes == timeComingInMinutes) || (timeExamInMinutes - timeComingInMinutes <= 30))
            {
                Console.WriteLine("On time");
            }
            else
	        {
                Console.WriteLine("Early");
            }

            if (timeExamInMinutes != timeComingInMinutes)
            {
                if (timeExamInMinutes - timeComingInMinutes < 60 && timeExamInMinutes - timeComingInMinutes > 0)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(timeExamInMinutes - timeComingInMinutes));
                }
                else if (timeComingInMinutes - timeExamInMinutes < 60 && timeComingInMinutes - timeExamInMinutes > 0)
                {
                    Console.WriteLine("{0} minutes after the start", timeComingInMinutes - timeExamInMinutes);
                }
                else if (timeExamInMinutes - timeComingInMinutes >= 60)
                {
                    hourLeft = (timeExamInMinutes - timeComingInMinutes) / 60;
                    minutesLeft = (timeExamInMinutes - timeComingInMinutes) % 60;

                    if (minutesLeft < 10)
                    {
                        Console.WriteLine($"{hourLeft} 0{minutesLeft} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourLeft} {minutesLeft} hours before the start");
                    }
                }
                else if (timeComingInMinutes - timeExamInMinutes >= 60)
                {
                    hourLeft = (timeComingInMinutes - timeExamInMinutes) / 60;
                    minutesLeft = (timeComingInMinutes - timeExamInMinutes) % 60;

                    if (minutesLeft < 10)
                    {
                        Console.WriteLine($"{hourLeft} 0{minutesLeft} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourLeft} {minutesLeft} hours after the start");
                    }
                } 
            }
        }
    }
}
