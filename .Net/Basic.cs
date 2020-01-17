using System;
using static System.Console;

namespace EX1A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding the circumference given the radius
            //variables
            double radius;
            double circ;

            //Getting user input for radius
            WriteLine("This equation finds the circumference of a circle given radius. Please enter the radius:");
            radius = Convert.ToDouble(ReadLine());

            //Putting input into equation
            circ = 2 * Math.PI * radius;

            //Outputing results
            WriteLine("The circumference of a circle with the radius of " + radius + " is " + circ);

            //Finding the area given the radius
            //additional variables needed
            double radius;
            double area;

            //Get user input
            WriteLine("This equation finds the area of a circle given radius. Please enter the radius:");
            radius = Convert.ToDouble(ReadLine());

            //Input into equation
            area = Math.PI * Math.Pow(radius, 2);

            //Output results
            WriteLine("The area of a circle with the radius of " + radius + " is " + area);

            //Finding the volume of a hemisphere given the radius
            //Define variables
            double radius;
            double volume;
            double fourThirds = (4 / 3);

            //Get user input
            WriteLine("This equation finds the volume of a hemisphere given radius. Please enter the radius:");
            radius = Convert.ToDouble(ReadLine());

            //Input into equation
            volume = (fourThirds * Math.PI * Math.Pow(radius, 3)) / 2;

            //Output results
            WriteLine("The volume of your hemisphere is " + volume);

            /* //Finding the area of a triangle given the length of the sides
             //Define variables
             double a;
             double b;
             double c;
             double area;

             //Get user input
             WriteLine("This equation finds the area of a triangle given the length of all sides. Please enter the first side:");
             a = Convert.ToDouble(ReadLine());
             WriteLine("Now enter the second side");
             b = Convert.ToDouble(ReadLine());
             WriteLine("Lastly, enter the third side");
             c = Convert.ToDouble(ReadLine());

             //Input into equation
             double p = a + b + c;
             area = p / (2 / Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

             //Display results
             WriteLine("The area of your triangle is " + area);*/

            /*//Solving a quadratic equation given a, b, and c
            //Define variables needed
            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;

            //Get user input
            WriteLine("This equation solves the quadratic equation given a, b, and c. Please enter a:");
            a = Convert.ToDouble(ReadLine());
            WriteLine("Now b;");
            b = Convert.ToDouble(ReadLine());
            WriteLine("Lastly, enter c;");
            c = Convert.ToDouble(ReadLine());

            //Calculate D
            d = Math.Pow(b, 2) - (4 * a * c);

            if (d == 0)
            {
                WriteLine("Both roots are equal. Therefore there is ONE real solution.");
                x1 = -b / (2.0 * a);
                x2 = x1;
                WriteLine("Root1 = " + x1);
                WriteLine("Root2 = " + x2);
            }
            else if (d > 0)
            {
                WriteLine("Both roots are greater than zero. Therefore there is TWO real solutions.");
                x1 = ((b * -1) - (Math.Sqrt(Math.Pow(b, 2) - ((4 * a * c))))) / (2 * a);
                x2 = ((b * -1) + (Math.Sqrt(Math.Pow(b, 2) - ((4 * a * c))))) / (2 * a);
                WriteLine("Root1 = " + x1);
                WriteLine("Root2 = " + x2);
            }
            else
            {
                WriteLine("Both roots are less than zero. Therefore there is NO solution.");*/
        }
        }
    }
}
