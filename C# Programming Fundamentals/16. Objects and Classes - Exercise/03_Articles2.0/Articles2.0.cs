using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ");

                string title = articleData[0];
                string content = articleData[1];
                string author = articleData[2];

                articles.Add(new Article(title, content, author));
            }

            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
            {
                articles.OrderBy(a => a.Title).ToList().ForEach(a => Console.WriteLine(a));
            }
            else if (orderCriteria == "content")
            {
                articles.OrderBy(a => a.Content).ToList().ForEach(a => Console.WriteLine(a));
            }
            else if (orderCriteria == "author")
            {
                articles.OrderBy(a => a.Author).ToList().ForEach(a => Console.WriteLine(a));
            }
        }
    }
}
