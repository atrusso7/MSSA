using System;
using System.Linq;
using Figgle;

namespace _10Feb.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Standard.Render("̿̿( o  o )"));
            Console.ForegroundColor = ConsoleColor.White;
            //Dog Timber = new Dog("Timber", "German Shepherd", 5, "Black/Tan");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Timber.makeString();

            //Student s1 = new Student(01, "Leeroy Jenkins", 71, "String Theory");
            //s1.showInfo();

            //MyStruct c1 = new MyStruct(1, 2, 3);
            //c1.PrintStatement();

            //Person P1;
            //P1.Name = "Mickey Moose";
            //P1.Age = 90;
            //P1.Weight = 120;

            //Console.WriteLine("P1 Name: " + P1.Name + "\nAge: " + P1.Age + "\nWeight: " + P1.Weight);

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //string[] cars1 = { "Toyota", "Kia", "Subaru", "Mercedes-Bens" };
            //Array.Copy(cars, cars1, 3);
            //for (int i = 0; i < cars1.Length; i++)
            //{
            //    Console.WriteLine(cars1[i]);
            //}
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] evenOdd = { 0, 1, 2, 3, 4, 5, 6 };
            //for (int i = 0; i < evenOdd.Length; i++)
            //{
            //    if (evenOdd[i] % 2 == 0)
            //        Console.Write(evenOdd[i] + " ");
            //}

            //double[] numbers = { -10.5, -3.4, 5.5, 35.7, 101.3, -99.5 };
            //Array.Sort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers1 = { 100, 35, 2, 11, 23, 3, 11 };
            //double average = numbers1.Average();
            //Console.WriteLine("Average: " + average);

            //int numberCount = numbers1.Count();
            //int halfIndex = numbers1.Count() / 2;
            //var sortedNumbers = numbers1.OrderBy(n => n);
            //double median;
            //if ((numberCount % 2) == 0)
            //{
            //    median = ((sortedNumbers.ElementAt(halfIndex) +
            //        sortedNumbers.ElementAt(halfIndex-1)) / 2);
            //}
            //else
            //{
            //    median = sortedNumbers.ElementAt(halfIndex);
            //}
            //Console.WriteLine(("Median: " + median));

            //var mode = numbers1.GroupBy(n => n).
            //OrderByDescending(g => g.Count()).
            //Select(g => g.Key).FirstOrDefault();
            //Console.WriteLine(("Mode: " + mode));
        }
        public struct Person
        {
            public string Name;
            public int Age, Weight;
        }
    }
}
