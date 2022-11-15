namespace CollectionHierarchy
{
    using Core;
    using Core.Contracts;
    using IO;
    public class StartUp
    {
        static void Main()
        {
            ConsoleReader reader = new ConsoleReader();
            ConsoleWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}