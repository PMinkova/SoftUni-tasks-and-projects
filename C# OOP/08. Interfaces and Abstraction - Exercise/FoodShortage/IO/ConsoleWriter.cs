namespace BorderControl.IO
{
    using System;
    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteLine(int number)
        {
            Console.WriteLine(number);
        }
    }
}
