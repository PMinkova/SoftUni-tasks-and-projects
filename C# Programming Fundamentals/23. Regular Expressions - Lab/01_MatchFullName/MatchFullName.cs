using System;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            var text = "Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan  Ivanov";

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
