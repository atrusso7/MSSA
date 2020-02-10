using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _28Jan.Net
{
    class Program
    {
        static void Main()
        {
            /*//nested loops
            for (int i = 2; i < 3; i++)
                for (int j = i; j < i; j++)
                    WriteLine("Buon Giorno");

            //lists
            List<int> numbers = new List<int> { 5, -8, 3, 14, 9, 17, 0, 4 };
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }
            WriteLine("Sum of my list = " + sum);

            //calling method to sum array
            int[] myArray = { 5, -8, 3, 14, 9, 17, 0, 4 };
            WriteLine("Sum of my array = " + MySum(myArray));

            //calling method to find max value
            WriteLine("The max value in the array = " + MaxValue(myArray));

            //try and catch snippet
            *//*int x = 1;
            int y = 0;
            try
            {
                double z = x / y;
            }
            catch
            {

                throw;
            }*//*
            Radius();

            //instatiating new class objects
            Book dune = new Book();
            dune.author = "Frank Herbert";
            dune.numPages = 412;
            dune.title = "Dune";

            Book institute = new Book();
            institute.author = "Stephen King";
            institute.title = "The Institute";
            institute.numPages = 576;

            Book harryPotter1 = new Book();
            harryPotter1.title = "Harry Potter and The Sorcerer's Stone";
            harryPotter1.numPages = 350;
            harryPotter1.author = "J.K. Rowling";*/

            Pig newPig = new Pig();
            Snake newSnake = new Snake();
            Monkey newMonkey = new Monkey();
            Zombie newZombie = new Zombie();
            WriteLine(newPig.Noise());
            WriteLine(newSnake.Noise()); 
            WriteLine(newMonkey.Noise());
            WriteLine(newZombie.Noise());
            WriteLine(newPig.Eat());
            WriteLine(newSnake.Eat());
            WriteLine(newMonkey.Eat());
            WriteLine(newZombie.Eat());
            WriteLine(newPig.Move());
            WriteLine(newSnake.Move());
            WriteLine(newMonkey.Move());
            WriteLine(newZombie.Move());
        }
        static void Radius() //includes error handling for all non-int and non-positive entrys
        {
            //Finding the circumference given the radius
            //variables
            double radius;
            double circ;

            try
            {
                //Getting user input for radius
                WriteLine("This equation finds the circumference of a circle given radius. Please enter the radius:");
                radius = Convert.ToDouble(ReadLine());
                if (radius < 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\n\nPositive numbers only. Try again: ");
                }
                //Putting input into equation
                circ = 2 * Math.PI * radius;

                //Outputing results
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The circumference of a circle with the radius of " + radius + " is " + circ);
            }
            catch
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n\nInvalid Entry. Try Again.");
                Radius();
            }
        }
        static int MySum(int[] myArray) //method that sums an array
        {
            int total = 0;
            foreach(int number in myArray)
            {
                total += number;
            }
            return total;
            //The better way to do it
            //int sum = myArray.Sum();
            //return sum;
        }
        static int MaxValue(int[] myArray)
        {
            int max = 0;
            foreach(int number in myArray)
            {
                if (max < number)
                {
                    max = number;
                }
            }
            return max;
        }
    }
}
