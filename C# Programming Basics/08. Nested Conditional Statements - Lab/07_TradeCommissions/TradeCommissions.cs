using System;

namespace _07_TradeCommissions
{
    class TradeCommissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volumSale = double.Parse(Console.ReadLine());

            double commision = -1;

            if (town == "Sofia")
            {
                if (0 <= volumSale && volumSale <=500)
                {
                    commision = 0.05;
                }
                else if (500 < volumSale && volumSale <= 1000)
                {
                    commision = 0.07;
                }
                else if (1000 < volumSale && volumSale <= 10000)
                {
                    commision = 0.08;
                }
                else if (volumSale > 10000)
                {
                    commision = 0.12;
                }

                if (commision >= 0)
                {
                    Console.WriteLine("{0:F2}", volumSale * commision);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (0 <= volumSale && volumSale <= 500)
                {
                    commision = 0.045;
                }
                else if (500 < volumSale && volumSale <= 1000)
                {
                    commision = 0.075;
                }
                else if (1000 < volumSale && volumSale <= 10000)
                {
                    commision = 0.1;
                }
                else if (volumSale > 10000)
                {
                    commision = 0.13;
                }
                if (commision >= 0)
                {
                    Console.WriteLine("{0:F2}", volumSale * commision);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (0 <= volumSale && volumSale <= 500)
                {
                    commision = 0.055;
                }
                else if (500 < volumSale && volumSale <= 1000)
                {
                    commision = 0.08;
                }
                else if (1000 < volumSale && volumSale <= 10000)
                {
                    commision = 0.12;
                }
                else if (volumSale > 10000)
                {
                    commision = 0.145;
                }
                if (commision >= 0)
                {
                    Console.WriteLine("{0:F2}", volumSale * commision);
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
