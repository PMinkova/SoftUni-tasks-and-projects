using System;

namespace P08_Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();

            var firstAndLastName = personInfo[0] + " " + personInfo[1];
            var adress = personInfo[2];
            var town = personInfo[3];

            if (personInfo.Length == 5)
            {
                town += " " + personInfo[4];
            }

            var tuple1 = new Tuple<string, string, string>(firstAndLastName, adress, town);

            var drinkInfo = Console.ReadLine().Split();
            var name = drinkInfo[0];
            var beerAmount = int.Parse(drinkInfo[1]);
            var infoAboutBeingDrunk = drinkInfo[2] == "drunk" ? true : false;

            var tuple2 = new Tuple<string, double, bool>(name, beerAmount, infoAboutBeingDrunk);

            var bankAccountInfo = Console.ReadLine().Split();
            var personName = bankAccountInfo[0];
            var accountBalance = double.Parse(bankAccountInfo[1]);
            var bankName = bankAccountInfo[2];

            var tuple3 = new Tuple<string, double, string>(personName, accountBalance, bankName);

            Console.WriteLine($"{tuple1.Item1} -> {tuple1.Item2} -> {tuple1.Item3}");
            Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2} -> {tuple2.Item3}");
            Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2} -> {tuple3.Item3}");
        }
    }
}
