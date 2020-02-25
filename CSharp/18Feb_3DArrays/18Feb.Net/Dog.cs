using System;
using System.Collections.Generic;
using System.Text;

namespace _18Feb.Net
{
    class Dog
    {
        public string name, breed, color;
        private int age;

        public Dog()
        {
            this.age = 2;
            this.name = "Jo";
            this.breed = "Great Dane";
            this.color = "Black";
        }

        public int setAge
        {
            set => this.age = 1;
        }
        public void DogInfo()
        {
            Console.WriteLine($"Age: {this.age}\nName: {this.name}\nBreed: {this.breed}\nColor: {this.color}");
        }
    }
}
