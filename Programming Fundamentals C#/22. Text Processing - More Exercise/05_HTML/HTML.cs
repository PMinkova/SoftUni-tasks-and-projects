using System;
using System.Text;

namespace _05_HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<h1>")
                .AppendLine(title)
                .AppendLine("</h1>")
                .AppendLine("<article>")
                .AppendLine(content)
                .AppendLine("</article>");

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {

                sb.AppendLine("<div>")
                    .AppendLine(comment)
                    .AppendLine("</div>");

                comment = Console.ReadLine();
            }

            Console.WriteLine(sb);

            int a = 5;
            int b = 10;

            bool areequal = false;

            if (!areequal)
            {
                b = a;
            }
            else
            {
                a = b;
            }
        }
    }
}
