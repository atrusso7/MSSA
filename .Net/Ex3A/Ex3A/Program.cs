using System;
using static System.Console;

namespace Ex3A
{
    class Program
    {
        static void Radius()
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
                Main();
            }
        }
        static void Hemisphere()
        {
            //Finding the volume of a hemisphere given the radius
            //Define variables
            double r;
            double volume;
            double fourThirds = (4 / 3);

            //Get user input
            WriteLine("Volume of a hemisphere given radius. Please enter the radius:");
            try
            {
                r = Convert.ToDouble(ReadLine());

                //Input into equation
                volume = (fourThirds * Math.PI * Math.Pow(r, 3)) / 2;

                //Output results
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The volume of your hemisphere is " + volume);
            }
            catch
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n\nInvalid Entry. Try Again.");
                Main();
            }
        }
        static void TriangleArea()
        {
            //Finding the area of a triangle given the length of the sides
            //Define variables
            double a;
            double b;
            double c;
            double area;

            //Get user input
            try
            {
                WriteLine("Area of a triangle given the length of all sides. Please enter the first side:");
                a = Convert.ToDouble(ReadLine());
                WriteLine("Now enter the second side");
                b = Convert.ToDouble(ReadLine());
                WriteLine("Lastly, enter the third side");
                c = Convert.ToDouble(ReadLine());

                //Input into equation
                double p = a + b + c;
                area = p / (2 / Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

                //Display results
                WriteLine("The area of your triangle is " + area);
            }
            catch
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n\nInvalid Entry. Try Again.");
                Main();
            }
        }
        static void Quadratic()
        {
            //Solving a quadratic equation given a, b, and c
            //Define variables needed
            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;

            try
            {
                //Get user input
                WriteLine("Quadratic equation given a, b, and c. Please enter a:");
                a = Convert.ToDouble(ReadLine());
                WriteLine("Now b;");
                b = Convert.ToDouble(ReadLine());
                WriteLine("Lastly, enter c;");
                c = Convert.ToDouble(ReadLine());

                //Calculate D
                d = Math.Pow(b, 2) - (4 * a * c);

                if (d == 0)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Both roots are equal. Therefore there is ONE real solution.");
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    WriteLine("Root1 = " + x1);
                    WriteLine("Root2 = " + x2);
                }
                else if (d > 0)
                {
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("Both roots are greater than zero. Therefore there is TWO real solutions.");
                    x1 = ((b * -1) - (Math.Sqrt(Math.Pow(b, 2) - ((4 * a * c))))) / (2 * a);
                    x2 = ((b * -1) + (Math.Sqrt(Math.Pow(b, 2) - ((4 * a * c))))) / (2 * a);
                    WriteLine("Root1 = " + x1);
                    WriteLine("Root2 = " + x2);
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Both roots are less than zero. Therefore there is NO solution.");
                    throw new Exception("No real solution");
                }
            }
            catch
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n\nInvalid Entry. Try Again.");
                Main();
            }
        }
        static void Main()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("(1.) Circumference\n(2.) Volume of Hemisphere\n(3.) Area of Triangle\n(4.) Quadratic Equation\n(5.) Exit\n\n");
            try
            {
                ForegroundColor = ConsoleColor.Blue;
                int n = Convert.ToInt32(ReadLine());
                if (n == 1)
                    Radius();
                else if (n == 2)
                    Hemisphere();
                else if (n == 3)
                    TriangleArea();
                else if (n == 4)
                    Quadratic();
                else if (n == 5)
                    System.Environment.Exit(0);
                else
                    throw new Exception("Invalid Entry");
            }
            catch
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Invalid Entry. Try Again.");
                Main();
            }
        }
    }
}
