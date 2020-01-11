using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersCountInSofia = int.Parse(Console.ReadLine());
            int stopsCount = int.Parse(Console.ReadLine());
            int passengersLeft = 0;
            
            

            for (int i = 1; i <= stopsCount; i++)
            {
                int on = int.Parse(Console.ReadLine());
                int off = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    passengersLeft = passengersCountInSofia - off + on + 2;
                }
                else
                {
                    passengersLeft = passengersCountInSofia - off + on - 2;
                }
                passengersCountInSofia = passengersLeft;
                
            }
            Console.WriteLine($"The final number of passengers is : {passengersLeft}");
        }
    }
}
