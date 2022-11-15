namespace ExplicitInterfaces
{
    using Core;
    using Core.Contracts;
    using IO;
    using IO.Contracts;
    internal class StartUp
    {
        static void Main()
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
