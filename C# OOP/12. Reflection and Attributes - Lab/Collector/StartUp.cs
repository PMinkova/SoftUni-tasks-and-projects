namespace Stealer
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            var spy = new Spy();
            var result = spy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}
