using System;
using System.Collections.Generic;

namespace _05_SoftUniParking
{
    class SoftUniParking
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> database = new Dictionary<string, string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string command = commands[0];
                string userName = commands[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = commands[2];
                        Register(userName, licensePlateNumber, database);
                        break;
                    case "unregister":
                        Unregister(userName, database);
                        break;
                }
            }

            foreach (var user in database)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static void Register(string userName, string licensePlateNumber, Dictionary<string, string> database)
        {
            bool isRegistered = CheckIfTheUserIsRegistered(userName, database);

            if (isRegistered)
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
            else
            {
                database.Add(userName, licensePlateNumber);
                Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
            }
        }

        static void Unregister(string userName, Dictionary<string, string> database)
        {
            bool isRegistered = CheckIfTheUserIsRegistered(userName, database);

            if (isRegistered)
            {
                database.Remove(userName);
                Console.WriteLine($"{userName} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {userName} not found");
            }
        }

        static bool CheckIfTheUserIsRegistered(string userName, Dictionary<string, string> register)
        {
            if (register.ContainsKey(userName))
            {
                return true;
            }

            return false;
        }
    }
}
