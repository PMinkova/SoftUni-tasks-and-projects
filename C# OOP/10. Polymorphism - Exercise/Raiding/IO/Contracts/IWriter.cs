﻿namespace Raiding.IO.Contracts
{
    public interface IWriter
    {
        void Write(object text);

        void WriteLine(object text);
    }
}