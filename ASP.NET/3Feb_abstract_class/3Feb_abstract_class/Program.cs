using System;

namespace _3Feb_abstract_class
{
    public abstract class Animal
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("ZzzZZZZ");
        }
    }
    public class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Pig goes OINK OINK");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.AnimalSound();
            pig.Sleep();
        }
    }
}
