namespace CommandPattern.Core
{
    using System;

    using CommandPattern.Utilities.Contracts;
    using Contracts;

    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    var commandArgs = Console.ReadLine();
                    var result = commandInterpreter.Read(commandArgs);

                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }
    }
}
