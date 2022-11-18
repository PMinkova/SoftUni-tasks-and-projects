namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Exceptions;
    using Factories.Contracts;
    using IO.Contracts;
    using Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly Ireader reader;
        private readonly IWriter writer;

        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        private ICollection<IAnimal> animals;

        private Engine()
        {
            this.animals = new HashSet<IAnimal>();
        }

        public Engine(Ireader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory)
            : this()
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {
            var input = reader.ReadLine();
            var counter = 0;

            while (input != "End")
            {
                try
                {
                    var currentAnimal = BuildAnimalUsingFactory(input);

                    var currentFood = BuildFoodUsingFactory();

                    writer.WriteLine(currentAnimal.ProduceSound());
                    currentAnimal.Eat(currentFood);

                    counter++;
                }
                catch (InvalidAnimalTypeException iae)
                {
                    writer.WriteLine(iae.Message);
                }
                catch (InvalidFoodTypeException ife)
                {
                    writer.WriteLine(ife.Message);
                }
                catch (ArgumentException ae)
                {
                    writer.WriteLine(ae.Message);
                }

                input = reader.ReadLine();
            }

            PrintAllAnimals();
        }

        private IFood BuildFoodUsingFactory()
        {
            var foodArguments = reader
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var foodType = foodArguments[0];
            var foodQuantity = int.Parse(foodArguments[1]);

            IFood food = foodFactory.CreateFood(foodType, foodQuantity);
            return food;
        }

        private IAnimal BuildAnimalUsingFactory(string input)
        {
            var animalArguments = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            IAnimal animal = animalFactory.CreateAnimal(animalArguments);
            animals.Add(animal);
            return animal;
        }

        private void PrintAllAnimals()
        {
            foreach (var animal in animals)
            {
                writer.WriteLine(animal);
            }
        }
    }
}
