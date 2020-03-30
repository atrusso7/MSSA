using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;

namespace _30Mar_ListGroup
{
    class Animal
    {
        public string Name { get; set; }
        
    }
    class GenericCompare<T>
    {
        public bool Compare(T a, T b)
        {
            if (a.Equals(b))
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static bool CompareTwoNumb (int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //Exercise 1
            var animalList = new List<Animal>();
            animalList.Add(new Animal(){ Name = "Goofy" });
            animalList.Add(new Animal(){ Name = "Mickey" });
            animalList.Add(new Animal(){ Name = "Pluto" });
            animalList.Add(new Animal(){ Name = "Minnie" });
            animalList.RemoveAt(1);
            animalList.Insert(1, new Animal(){ Name = "Daisy"});

            foreach (var v in animalList)
            {
                Console.WriteLine(v.Name);
            }
            Console.WriteLine($"\tCount: {animalList.Count}");

            //Exercise 2
            System.Console.WriteLine(CompareTwoNumb( 3, 3 ));
            System.Console.WriteLine(CompareTwoNumb( 7, 199 ));
            var g = new GenericCompare<int>();
            System.Console.WriteLine(g.Compare( 3, 3));
            System.Console.WriteLine(g.Compare( 7, 199));
            var gString = new GenericCompare<string>();
            System.Console.WriteLine(gString.Compare( "Corona", "Corona"));
            System.Console.WriteLine(gString.Compare( "Covid-19", "Covid-18"));
        }
    }
}
