using System;


namespace _01_WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] commandArgs = input.Split(":");

                string command = commandArgs[0];

                if (command == "Add Stop")
                {
                    stops = AddStop(commandArgs, stops);
                    Console.WriteLine(stops);
                }
                else if (command == "Remove Stop")
                {
                    stops = RemoveElements(commandArgs, stops);
                    Console.WriteLine(stops);
                }
                else if (command == "Switch")
                {
                    string oldString = commandArgs[1];
                    string newString = commandArgs[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                        Console.WriteLine(stops);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        private static string RemoveElements(string[] commandArgs, string stops)
        {
            int startIndex = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);

            if (IsIndexValid(startIndex, stops) && IsIndexValid(endIndex, stops))
            {
                int count = endIndex - startIndex + 1;
                stops = stops.Remove(startIndex, count);
            }

            return stops;
        }

        static string AddStop(string[] commandArgs, string stops)
        {
            int index = int.Parse(commandArgs[1]);
            string stringToAdd = commandArgs[2];

            if (IsIndexValid(index, stops))
            {
                stops = stops.Insert(index, stringToAdd);
            }

            return stops;
        }

        static bool IsIndexValid(int index, string stops)
        {
            if (0 <= index && index < stops.Length)
            {
                return true;
            }

            return false;
        }
    }
}
