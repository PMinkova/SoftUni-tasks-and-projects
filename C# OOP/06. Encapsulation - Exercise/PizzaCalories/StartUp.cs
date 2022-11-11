using System;
using System.Linq;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main()
        {
            try
            {
                var pizzaName = Console.ReadLine().Split(" ")[1];
                var pizza = new Pizza(pizzaName);

                var doughArguments = Console.ReadLine().Split(" ").ToArray();

                var flowerType = doughArguments[1];
                var bakingTechnique = doughArguments[2];
                var grams = double.Parse(doughArguments[3]);

                pizza.Dough = new Dough(flowerType, bakingTechnique, grams);

                var inputToppings = Console.ReadLine();

                while (inputToppings != "END")
                {
                    var toppingsArguments = inputToppings.Split(" ");

                    var toppingType = toppingsArguments[1];
                    var toppingGrams = double.Parse(toppingsArguments[2]);

                    var topping = new Topping(toppingType, toppingGrams);

                    pizza.AddTopping(topping);

                    inputToppings = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
