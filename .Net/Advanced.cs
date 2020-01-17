using System;
using static System.Console;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double d, x1, x2;
            Write("\n\n");
            Write("Calculate root of Quadratic Equation :\n");
            Write("----------------------------------------");
            Write("\n\n");

            Write("Input the value of a : ");
            a = Convert.ToInt32(ReadLine());
            Write("Input the value of b : ");
            b = Convert.ToInt32(ReadLine());
            Write("Input the value of c : ");
            c = Convert.ToInt32(ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Write("First  Root = {0}\n", x1);
                Write("Second Root = {0}\n", x2);
            }
            else if (d > 0)
            {
                Write("Both roots are real\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Write("First Root = {0}\n", x1);
                Write("Second Root = {0}\n", x2);
            }
            else
                Write("No Solution. \n\n");
        }
    }
}
