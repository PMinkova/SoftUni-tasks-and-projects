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
    class MessageMenager
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

                    AddANonexistingUser(users, username, sentMessages, receivedMessages);
                }
                else if (command == "Message")
                {
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender].Sent++;
                        RemoveUserIfReachedCapacity(users, sender, capacity);

                        users[receiver].Received++;
                        RemoveUserIfReachedCapacity(users, receiver, capacity);
                    }
                }
                else if (command == "Empty")
                {
                    string username = commandArgs[1];
                    RemoveUser(username, users);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in users.OrderByDescending(x => x.Value.Received).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sum}");
            }
        }

        private static void RemoveUser(string username, Dictionary<string, UserReport> users)
        {
            if (username == "All")
            {
                users.Clear();
            }
            else
            {
                users.Remove(username);
            }
        }

        private static void RemoveUserIfReachedCapacity(Dictionary<string, UserReport> users, string user, int capacity)
        {
            if (users[user].Sum >= capacity)
            {
                Console.WriteLine($"{user} reached the capacity!");
                users.Remove(user);
            }
        }

        private static void AddANonexistingUser(Dictionary<string, UserReport> users, string username, int sentMessages, int receivedMessages)
        {
            if (!users.ContainsKey(username))
            {
                users.Add(username, new UserReport(sentMessages, receivedMessages));
            }
        }
    }
}
