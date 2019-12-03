using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MessageMenager
{
    class UserReport
    {
        public UserReport(int sent, int received)
        {
            Sent = sent;
            Received = received;
        }
        public int Sent { get; set; }

        public int Received { get; set; }

        public int Sum => this.Sent + this.Received;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, UserReport> users = new Dictionary<string, UserReport>();

            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] commandArgs = input.Split("=");
                string command = commandArgs[0];

                if (command == "Add")
                {
                    string username = commandArgs[1];
                    int sentMessages = int.Parse(commandArgs[2]);
                    int receivedMessages = int.Parse(commandArgs[3]);

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new UserReport(sentMessages, receivedMessages));
                    }

                }
                else if (command == "Message")
                {
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender].Sent++;

                        if (users[sender].Sum >= capacity)
                        {
                            users.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }

                        users[receiver].Received++;

                        if (users[receiver].Sum >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            users.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string username = commandArgs[1];

                    if (username == "All")
                    {
                        users.Clear();
                    }
                    else
                    {
                        users.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in users.OrderByDescending(x => x.Value.Received).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sum}");
            }
        }
    }
}
