using System;
using System.Collections.Generic;

namespace Animals
{
    public class Engine
    {
        private readonly List<Animal> animals;

        public Engine()
        {
            animals = new List<Animal>();
        }

        public void Run()
        {
            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                var animalArgs = Console.ReadLine()
                    .Split(" ");

                Animal animal;

                try
                {
                    animal = GetAnimal(animalType, animalArgs);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }

                this.animals.Add(animal);
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string animalType, string[] animalArgs)
        {
            var name = animalArgs[0];
            var age = int.Parse(animalArgs[1]);
            var gender = GetAnimalsGender(animalArgs);

            Animal animal = null;

            switch (animalType)
            {
                case "Dog":
                    animal = new Dog(name, age, gender);
                    break;
                case "Frog":
                    animal = new Frog(name, age, gender);
                    break;
                case "Cat":
                    animal = new Cat(name, age, gender);
                    break;
                case "Kitten":
                    animal = new Kitten(name, age);
                    break;
                case "Tomcat":
                    animal = new Tomcat(name, age);
                    break;
                default:
                    throw new ArgumentException("Invalide input!");
            }

            return animal;
        }

        private static string GetAnimalsGender(string[] animalArgs)
        {
            var gender = string.Empty;

            if (animalArgs.Length == 3)
            {
                gender = animalArgs[2];
            }

            return gender;
        }
    }
}
