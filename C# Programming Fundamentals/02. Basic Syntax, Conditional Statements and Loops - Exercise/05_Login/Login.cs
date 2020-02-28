using System;

namespace _05_Login
{
    class Login
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string pass = "";
            int inputCounter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                pass += username[i];
            }

            while (password != pass && inputCounter < 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
                inputCounter++;
                password = Console.ReadLine();
            }

            if (pass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
