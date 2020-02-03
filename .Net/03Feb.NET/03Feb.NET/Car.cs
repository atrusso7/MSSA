using System;
using System.Collections.Generic;
using System.Text;

namespace _03Feb.NET
{
    class Car
    {
        public int MaxSpeed;
        public string Color;
        public void FullThrottle()
        {
            Console.WriteLine("THIS CAR IS GOING FAAAAAAAAAAAAAAAAAST");
        }
        public void DescribeCar()
        {
            Console.WriteLine("Car Color: " + Color + "\nMax Speed: " + MaxSpeed + " MPH");
        }
        public void InsertData(string color, int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            Color = color;
        }
    }
}
