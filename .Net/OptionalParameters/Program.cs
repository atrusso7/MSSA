using System;
using static System.Console;

namespace OptionalParameters
{
    class Program
    {
        // Can be called with 0, 1, or 2 parameters
        public static void AnimalSound(string animal = "duck", string sound = "quack")
        {
            WriteLine($"The {animal} goes \"{sound}\"!");
        }
        static void Main(string[] args)
        {
            string animal = "duck";
            WriteLine(AnimalSound(animal));
        }
    }
}
