using System;

namespace _07_OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double result = 0.0;

            //Събиране(+), Изваждане(-), Умножение(*),
            //Деление(/) и Модулно деление(%).
            //

            if (symbol == '+' || symbol == '-' || symbol == '*' )
            {
                if (symbol == '+')
                {
                    result = n1 + n2;
                }
                else if (symbol == '-')
                {
                    result = n1 - n2;
                }
                else if (symbol == '*')
                {
                    result = n1 * n2;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, symbol, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, symbol, n2, result);
                }
            }
            else if (symbol == '/')
            {
                result = n1 / n2;
                if (n2 != 0)
                {
                    Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, result);                
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }   
            }
            else if (symbol == '%')
            {
                result = n1 % n2;
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else
	            {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }

        }
    }
}
