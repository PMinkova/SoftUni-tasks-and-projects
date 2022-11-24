namespace CommandPattern.Utilities
{
    using System;
    using System.Linq;
    using System.Reflection;
    using CommandPattern.Models.Contracts;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var argsArray = args.Split(' ').ToArray();

            var commandName = argsArray[0] + "Command";
            var arguments = argsArray.Skip(1).ToArray();

            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandName);

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command type!");
            }

            var command = (ICommand)Activator.CreateInstance(type);

            return command.Execute(arguments);
        }
    }
}
