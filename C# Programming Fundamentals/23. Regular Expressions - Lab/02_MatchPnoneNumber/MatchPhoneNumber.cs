using System;
using System.Text.RegularExpressions;

namespace _02_MatchPnoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\+359(-| )2\1\d{3}\1\d{4}\b");

            var text = Console.ReadLine();

            var matches = regex.Matches(text);

            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
