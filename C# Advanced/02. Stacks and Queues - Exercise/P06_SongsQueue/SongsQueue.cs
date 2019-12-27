using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SongsQueue
{
    class SongsQueue
    {
        static void Main(string[] args)
        {
            string[] songsToEnqueue = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(songsToEnqueue);

            while (songs.Any())
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", songs));
                        break;
                    default:
                        AddSong(command, songs);
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }

        private static void AddSong(string command, Queue<string> songs)
        {
            string currentSong = command.Substring(4, command.Length - 4);

            if (!songs.Contains(currentSong))
            {
                songs.Enqueue(currentSong);
            }
            else
            {
                Console.WriteLine($"{currentSong} is already contained!");
            }
        }
    }
}
