using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            try
            {
                AddPeople(people);
                AddProducts(products);


                var input = Console.ReadLine();

                while (input != "END")
                {
                    var inputArgs = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var name = inputArgs[0];
                    var product = inputArgs[1];

                    var currentPerson = people.FirstOrDefault(p => p.Name == name);
                    var currentProduct = products.FirstOrDefault(p => p.Name == product);

                    currentPerson.BuyProduct(currentProduct);

                    input = Console.ReadLine();
                }

                PrintOutput(people);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static void AddProducts(List<Product> products)
        {
            var inputProducts = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inputProducts.Length; i++)
            {
                var productsArguments = inputProducts[i].Split('=');

                var productName = productsArguments[0];
                var productCost = decimal.Parse(productsArguments[1]);


                var product = new Product(productName, productCost);
                products.Add(product);

            }
        }

        private static void AddPeople(List<Person> people)
        {
            var inputPeople = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inputPeople.Length; i++)
            {
                var peopleArguments = inputPeople[i].Split('=');

                var personsName = peopleArguments[0];
                var money = decimal.Parse(peopleArguments[1]);


                var person = new Person(personsName, money);
                people.Add(person);
            }
        }

        private static void PrintOutput(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
