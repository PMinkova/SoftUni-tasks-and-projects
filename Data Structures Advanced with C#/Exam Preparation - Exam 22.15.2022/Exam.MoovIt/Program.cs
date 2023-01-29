using System;

namespace Exam.MoovIt
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var route = new Route("1", 3, 5, true, new List<string>() { "Sofia", "Plovdiv", "Varna" });
            var route2 = new Route("2", 3, 3, false, new List<string>() { "Sofia", "Pazardjik", "Varna" });

            var hash = new HashSet<Route>();

            hash.Add(route);
            hash.Add(route2);


            Console.WriteLine(hash.Count);
        }
    }
}