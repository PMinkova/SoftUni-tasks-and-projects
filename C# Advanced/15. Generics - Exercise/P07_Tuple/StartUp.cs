using System;

namespace P07_Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            var nameAndAdress = Console.ReadLine().Split();

            var firstAndLastName = nameAndAdress[0] + " " + nameAndAdress[1];
            var adress = nameAndAdress[2];

            var tuple1 = new Tuple<string, string>(firstAndLastName, adress);

            var nameAndBeerAmount = Console.ReadLine().Split();
            var name = nameAndBeerAmount[0];
            var beerAmount = int.Parse(nameAndBeerAmount[1]);

            var tuple2 = new Tuple<string, double>(name, beerAmount);

            var integerAndDouble = Console.ReadLine().Split();
            var integerNumber = int.Parse(integerAndDouble[0]);
            var doubleNumber = double.Parse(integerAndDouble[1]);

            var tuple3  = new Tuple<int, double>(integerNumber, doubleNumber);

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
