﻿namespace WildFarm.IO
{
    using System;

    using Contracts;

    public class ConsoleWriter : IWriter
    {
        public void Write(object text)
        {
            Console.Write(text.ToString());
        }

        public void WriteLine(object text)
        {
            Console.WriteLine(text.ToString());
        }
    }
}