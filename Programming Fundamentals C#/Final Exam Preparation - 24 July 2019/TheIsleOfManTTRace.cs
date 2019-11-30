using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace _03_TheIsleOfManTTRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regex = new Regex(@"([#$%&*])(?<name>[A-Za-z]+)(\1)=(?<length>\d+)!!(?<geohashcode>\S+)\b");

            //string input = Console.ReadLine();

            //string nameOfRacer = String.Empty;
            //string geohashcode = String.Empty;

            //while (true)
            //{
            //    Match match = regex.Match(input);

            //    if (match.Success)
            //    {
            //        int length = int.Parse(match.Groups["length"].ToString());
            //        int geohashCodeLength = match.Groups["geohashcode"].Length;

            //        if (length == geohashCodeLength)
            //        {

            //            char[] geohashCodeAsCharArray = match.Groups["geohashcode"].ToString().ToCharArray();

            //            for (int i = 0; i < geohashCodeAsCharArray.Length; i++)
            //            {
            //                geohashCodeAsCharArray[i] += (char)length;
            //            }

            //            geohashcode = new string(geohashCodeAsCharArray);
            //            match = regex.Match(input);
            //            nameOfRacer = match.Groups["name"].ToString();
            //            break;
            //        }
            //    }

            //    Console.WriteLine("Nothing found!");

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Coordinates found! {nameOfRacer} -> {geohashcode}");

            string input = "aaaaaaaaa!!bbbbbbb!!cccccc";

            string[] array = input.Split("!!", 2);

            Console.WriteLine();
        }
    }
}
