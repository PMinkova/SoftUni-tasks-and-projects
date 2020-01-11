using System;

namespace _05_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            change *= 100;
            int stotinki = (int)change;
            int coinsCounter = 0;

            while (stotinki > 0)
            {
                if (stotinki >= 400)
                {
                    coinsCounter = stotinki / 200;
                    stotinki = stotinki % 200;
                }

                if (stotinki >= 200)
                {
                    stotinki = stotinki % 200;
                }
                else if (100 <= stotinki)
                {
                    stotinki = stotinki % 100;
                }
                else if (stotinki >= 50)
                {
                    stotinki = stotinki % 50;
                }
                else if (stotinki >= 40)
                {
                    stotinki = stotinki % 40;
                    coinsCounter++;
                }
                else if (stotinki >= 20)
                {
                    stotinki = stotinki % 20;
                }
                else if (stotinki >= 10)
                {
                    stotinki = stotinki % 10;
                }
                else if (stotinki >= 5)
                {
                    stotinki = stotinki % 5;
                }
                else if (stotinki == 4)
                {
                    coinsCounter += 2;
                    break;
                }
                else if (stotinki >= 2)
                {
                    stotinki = stotinki % 2;
                }
                else if (stotinki == 1)
                {
                    stotinki = stotinki % 1;
                }

                coinsCounter++;
            }

            Console.WriteLine(coinsCounter);

        }
    }
}
