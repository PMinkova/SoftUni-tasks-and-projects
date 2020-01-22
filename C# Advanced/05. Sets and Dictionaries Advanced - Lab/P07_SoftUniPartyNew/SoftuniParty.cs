using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace P07_SoftUniParty
{
    class SoftuniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> guestListVIP = new HashSet<string>();
            HashSet<string> guestListRegular = new HashSet<string>();

            string input = Console.ReadLine();

            bool isVIPGuest = char.IsDigit(input[0]);

            while (input != "PARTY")
            {
                if (isVIPGuest)
                {
                    guestListVIP.Add(input);
                }
                else
                {
                    guestListRegular.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END" && guestListVIP.Contains(input) || guestListRegular.Contains(input))
            {
                if (isVIPGuest)
                {
                    guestListVIP.Remove(input);
                }
                else
                {
                    guestListRegular.Remove(input);
                }

                input = Console.ReadLine();
            }

            int guestsCount = guestListVIP.Count + guestListRegular.Count;
            Console.WriteLine(guestsCount);

            foreach (var VIPguest in guestListVIP)
            {
                Console.WriteLine(VIPguest);
            }

            foreach (var regularGuest in guestListRegular)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}
