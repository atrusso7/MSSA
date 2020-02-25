using System;
using static System.Console;

namespace QuadraticEquations
{
    class Program
    {
        static int Discriminant(int a, int b, int c)
        {
            int d;
            d = b * b - 4 * a * c;
            return d;
        }
        static Tuple<double, double> QuadRoot(int a, int b, int c)
        {
            double d, x1, x2;
            d = Discriminant(a, b, c);
            if (d == 0)
            {
                Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;

                return Tuple.Create(x1, x2);
            }
            else if (d > 0)
            {
                Write("Both roots are real\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return Tuple.Create(x1, x2);
            }
            else
                WriteLine("No real answer\nDiscriminant = " + d);
                return null;
        }
        static void Main(string[] args)
        {
            Write("\n\n");
            Write("Calculate root of Quadratic Equation :\n");
            Write("----------------------------------------");
            Write("\n\n");
            int a, b, c;
            Write("Input the value of a: ");
            a = Convert.ToInt32(ReadLine());
            Write("Input the value of b: ");
            b = Convert.ToInt32(ReadLine());
            Write("Input the value of c: ");
            c = Convert.ToInt32(ReadLine());
            WriteLine(QuadRoot(a, b, c));
        }
    }
}
