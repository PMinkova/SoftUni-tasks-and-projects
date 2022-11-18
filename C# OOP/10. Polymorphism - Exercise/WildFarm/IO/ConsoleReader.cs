namespace WildFarm.IO
{
    using System;

    using Contracts;

    public class ConsoleReader : Ireader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}