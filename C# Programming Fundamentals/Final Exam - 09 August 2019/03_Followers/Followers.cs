using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Followers
{
    class UserReport 
    {
        public UserReport(int likes = 0, int comments = 0)
        {
            Likes = likes;
            Comments = comments;
        }
        public int Likes { get; set; }

        public int Comments { get; set; }

        public int Sum => this.Likes + this.Comments;
    }
    class Followers
    {
        static void Main(string[] args)
        {
            Dictionary<string, UserReport> users = new Dictionary<string, UserReport>();
            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] commandArgs = input.Split(": ");

                string command = commandArgs[0];
                string username = commandArgs[1];

                if (command == "New follower")
                {
                    AddNewUserIfIsNotInTheList(users, username);
                }
                else if (command == "Like")
                {
                    int likesCount = int.Parse(commandArgs[2]);

                    AddNewUserIfIsNotInTheList(users, username);
                    users[username].Likes += likesCount;
                }
                else if (command == "Comment")
                {
                    AddNewUserIfIsNotInTheList(users, username);
                    users[username].Comments++;
                }
                else if (command == "Blocked")
                {
                    BlockUserIfExist(users, username);
                }

                input = Console.ReadLine();
            }

            PrintAllFollowers(users);
        }

        private static void BlockUserIfExist(Dictionary<string, UserReport> users, string username)
        {
            if (users.ContainsKey(username))
            {
                users.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} doesn't exist.");
            }
        }

        private static void PrintAllFollowers(Dictionary<string, UserReport> users)
        {
            Console.WriteLine($"{users.Keys.Count} followers");

            foreach (var user in users.OrderByDescending(u => u.Value.Likes).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value.Sum}");
            }
        }

        private static void AddNewUserIfIsNotInTheList(Dictionary<string, UserReport> users, string username)
        {
            if (!users.ContainsKey(username))
            {
                users.Add(username, new UserReport());
            }
        }
    }
}
