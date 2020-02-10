using System;
using System.Collections.Generic;
using System.Text;

namespace _10Feb.NET
{
    class Dog
    {
        public string name, breed, color;
        public int age;
        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }
        public string getName()
        {
            return name;
        }
        public string getBreed()
        {
            return breed;
        }
        public string getColor()
        {
            return color;
        }
        public int getAge()
        {
            return age;
        }
        public void makeString()
        {
            Console.WriteLine("Hi, my name is " + name + ". My breed is " + breed + ", I am " + age + " years old and my color is " + color + ".");
        }
    }
}
