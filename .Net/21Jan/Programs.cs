using System;
using static System.Console;

namespace _21Jan
{
    class Program
    {
        public static void MyMethod() //Simple Method and calling method
        {
            WriteLine("I just got called!");
        }
        public static int Sum(int num1, int num2) // a method adding two numbers with returning value
        {
            int total;
            total = num1 + num2;
            return total; 
        }
        public static double triAreaTotal(double s1, double s2, double s3)
        {
            double s = (s1 + s2 + s3) / 2;
            double t = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
            if ((s < s1) || (s < s2) || (s < s3))
            {
                WriteLine("You have a negative number under the square root. Can't have a negative area");
            }
            else
            {
                WriteLine("Area = " + t);
            }
            return t;
        }
        public static string evenOdd(int num1)
        {
            int mod = num1 % 2;

            if (mod == 0)
            {
                return ("The " + num1 + " is even.");
            }
            else
            {
                return ("The " + num1 + " is odd.");
            }
        }
        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        public static double ClassAverage(double g1, double g2, double g3, double g4, double g5, double g6, double g7, double g8, double g9, double g10)
        {
            double average = (g1 + g2 + g3 + g4 + g5 + g6 + g7 + g8 + g9 + g10) / 10;

            if (average < 60)
            {
                WriteLine("You Failed");
                return average;
            }
            else if (average < 70)
            {
                WriteLine("You Got a D");
                return average;
            }
            else if (average < 80)
            {
                WriteLine("You Got a C");
                return average;
            }
            else if (average < 90)
            {
                WriteLine("You Got a B");
                return average;
            }
            else if (average > 90)
            {
                WriteLine("You Got an A");
                return average;
            }
            else
            {
                WriteLine("Invalid Entry");
                return average;
            }
        }
        static void Main(string[] args)
        {
            //Calculating Averages
            WriteLine("Calculate Your Class Average (10 Grades Required)");
            WriteLine("\n\nInsert your 10 grades, press enter after each entry: ");
            WriteLine("Grade 1");
            double g1 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 2");
            double g2 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 3");
            double g3 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 4");
            double g4 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 5");
            double g5 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 6");
            double g6 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 7");
            double g7 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 8");
            double g8 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 9");
            double g9 = Convert.ToDouble(ReadLine());
            WriteLine("Grade 10");
            double g10 = Convert.ToDouble(ReadLine());
            WriteLine(ClassAverage(g1, g2, g3, g4, g5, g6, g7, g8, g9, g10));

            //Monte Carlo      

            //Fibonacci sequence
            //WriteLine("---Fibonacci Sequence Initiated---");
            //WriteLine("\n\nEnter n: ");
            //int n = Convert.ToInt32(ReadLine());
            //WriteLine("The result is: " + Fibonacci(n));

            //Calling evenOdd method to check if a number is even
            //WriteLine("Check if your number is odd or even");
            //WriteLine("-----------------------------------");
            //WriteLine("---------Enter the number----------");
            //int num1 = Convert.ToInt32(ReadLine());
            //WriteLine(evenOdd(num1));

            //Using triArea method to find the area of a triangle
            //Write("----------------------------------\n");
            //Write("--Find the area of a Triangle /\\--\n");
            //Write("----------------------------------\n");
            //Write("\n\nEnter the length of all three side...\n");
            //Write("\nFirst: \n");
            //double side1 = Convert.ToDouble(ReadLine());
            //Write("Second: \n");
            //double side2 = Convert.ToDouble(ReadLine());
            //Write("Third: \n");
            //double side3 = Convert.ToDouble(ReadLine());
            //Write("\n\nThe area of your triangle is: " + triAreaTotal(side1, side2, side3));

            //Calculating the sum using a method and two numbers
            //Write("-------------------------------------------------\n");
            //Write("--Function to calculate the sum of two numbers:--\n"); //\n means Line Feed
            //Write("-------------------------------------------------\n");
            //Write("Enter a number: ");
            //int n1 = Convert.ToInt32(ReadLine());
            //Write("Enter another number: ");
            //int n2 = Convert.ToInt32(ReadLine());
            //WriteLine("\nThe sum of the two numbers is: " + Sum(n1, n2));
        }
    }
}
