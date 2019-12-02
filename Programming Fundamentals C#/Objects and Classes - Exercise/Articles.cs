using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Articles
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");

            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(": ");

                string command = commandArgs[0];
                string newContent = commandArgs[1];
                string newAuthor = commandArgs[1];
                string newTitle = commandArgs[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }
}
