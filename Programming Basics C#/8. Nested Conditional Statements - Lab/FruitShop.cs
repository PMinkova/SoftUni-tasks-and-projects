using System;

namespace _06_FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitName = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double amount = -1;
          
            if (dayOfWeek == "Monday" ||
                dayOfWeek == "Tuesday" ||
                dayOfWeek == "Wednesday" ||
                dayOfWeek == "Thursday" ||
                dayOfWeek == "Friday")
            {
                if (fruitName == "banana")
                {
                    amount = quantity * 2.50;
                }
                else if (fruitName == "apple")
                {
                    amount = quantity * 1.20;
                }
                else if (fruitName == "orange")
                {
                    amount = quantity * 0.85;
                }
                else if (fruitName == "grapefruit")
                {
                    amount = quantity * 1.45;
                }
                else if (fruitName == "kiwi")
                {
                    amount = quantity * 2.70;
                }
                else if (fruitName == "pineapple")
                {
                    amount = quantity * 5.50;
                }
                else if (fruitName == "grapes")
                {
                    amount = quantity * 3.85;
                }
                if (amount >= 0)
                {
                    Console.WriteLine("{0:F2}", amount);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if(dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
               
                if (fruitName == "banana")
                    {
                        amount = quantity * 2.70;
                    }
                else if (fruitName == "apple")
                    {
                        amount = quantity * 1.25;
                    }
                else if (fruitName == "orange")
                    {
                        amount = quantity * 0.90;
                    }
                else if (fruitName == "grapefruit")
                    {
                        amount = quantity * 1.60 ;
                    }
                else if (fruitName == "kiwi")
                    {
                        amount = quantity * 3.00;
                    }
                else if (fruitName == "pineapple")
                    {
                        amount = quantity * 5.60;
                    }
                else if (fruitName == "grapes")
                    {
                        amount = quantity * 4.20;
                    }
                
                if (amount >= 0)
                {
                    Console.WriteLine("{0:F2}", amount);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
