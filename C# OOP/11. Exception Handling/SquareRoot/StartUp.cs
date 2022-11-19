namespace SquareRoot
{
    using System;

    public class StartUp
    {
        static void Main()
        {

            try
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 0 )
                {
                    throw new Exception("Invalid number.");
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
