﻿namespace NavalVessels.IO
{
    using System;
    using System.IO;
    using Contracts;

    public class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
