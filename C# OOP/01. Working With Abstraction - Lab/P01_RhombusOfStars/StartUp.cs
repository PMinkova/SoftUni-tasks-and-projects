using System;
using System.Text;
using System.Threading.Channels;

namespace P01_RhombusOfStars
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            PrintTopPart(n, sb);
            PrintLineOfStars(n, sb);
            PrintBottomPart(n, sb);
 
            Console.WriteLine(sb);
        }

        private static void PrintBottomPart(int n, StringBuilder sb)
        {
            for (int i = n - 1; i > 0; i--)
            {
                sb.Append(new String(' ', n - i));
                PrintLineOfStars(i, sb);
            }
        }

        private static void PrintTopPart(int n, StringBuilder sb)
        {
            for (int i = 1; i < n; i++)
            {
                sb.Append(new String(' ', n - i));
                PrintLineOfStars(i, sb);
            }
        }

        private static void PrintLineOfStars(int starsCount, StringBuilder sb)
        {
            for (int j = 0; j < starsCount; j++)
            {
                sb.Append("*");
                sb.Append(" ");
            }

            sb.AppendLine();
        }
    }
}
