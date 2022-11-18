namespace Raiding
{
    using Core;
    using Core.Contracts;
    using Factories;
    using Factories.Contracts;
    using IO;
    using IO.Contracts;

    public class StartUp
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IBaseHeroFactory baseHeroFactory = new BaseHeroFactory();

            IEngine engine = new Engine(reader, writer, baseHeroFactory);
            engine.Run();
        }
    }
}
