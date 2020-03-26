using System;
using System.Collections.Generic;

namespace _25Mar_Group_Indexer
{
    //Create a class call Animal with two properties as following
    class Animal
    {
        public string AnimalType {get; set;}
        public int Legs {get; set;}
        public Animal(string animalType, int legs)
        {
            this.AnimalType = animalType;
            this.Legs = legs;
        }
    }
    class MyAnimals 
    //a) within this class using List<> to create a variable to hold a list of Animals b) Create a constructor and initialize two AnimalTypes
    {
        List<Animal> listOfAnimals = new List<Animal>();
        public MyAnimals()
        {
            listOfAnimals.Add(new Animal("Tiger", 4));
            listOfAnimals.Add(new Animal("Bird", 2));
            listOfAnimals.Add(new Animal("Dog", 4));
            listOfAnimals.Add(new Animal("Kangaroo", 2));
            listOfAnimals.Add(new Animal("Godzilla", 2));
            listOfAnimals.Add(new Animal("Tony", 3));
        }
        public void GetAnimal(string animal)
        {
            var value = listOfAnimals.Find(item => item.AnimalType == animal);
            System.Console.WriteLine("Animal: " + value.AnimalType + "\nNumber of Legs: " + value.Legs);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyAnimals l1 = new MyAnimals();
            l1.GetAnimal("Bird");
            l1.GetAnimal("Dog");
        }
    }
}
