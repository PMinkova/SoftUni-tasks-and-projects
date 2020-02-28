using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06_ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)[a-z]{1}\w*\-?\.*?\w+\@[a-z]+\-?[a-z]+\.{1}[a-z]{2,}(\.[a-z]+)?";

            string text = Console.ReadLine();

            var regex = new Regex(pattern);

            var emails = regex.Matches(text);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
