using System;
using static System.Console;

namespace Lab3dMathApp
{
    class Program
    {
        static int Plus()
        {
            int a, b;
            WriteLine("a + b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a + b;
            WriteLine(a + " + " + b + " = " + total);
            return total;
        }
        static int Subtract()
        {
            int a, b;
            WriteLine("a - b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a - b;
            WriteLine(a + " - " + b + " = " + total);
            return total;
        }
        static int Multiply()
        {
            int a, b;
            WriteLine("a x b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a * b;
            WriteLine(a + " x " + b + " = " + total);
            return total;
        }
        static int Divide()
        {
            int a, b;
            WriteLine("a / b = ?\nEnter a: ");
            a = Convert.ToInt32(ReadLine());
            WriteLine("Enter b: ");
            b = Convert.ToInt32(ReadLine());
            int total = a / b;
            WriteLine(a + " / " + b + " = " + total);
            return total;
        }
        static void Main()
        {
            WriteLine("(1.) Add\n(2.) Subtract\n(3.) Multiply\n(4.) Divide\n(5.) Exit");
            try
            {
                int n = Convert.ToInt32(ReadLine());
                if (n == 1)
                    WriteLine(Plus());
                else if (n == 2)
                    WriteLine(Subtract());
                else if (n == 3)
                    WriteLine(Multiply());
                else if (n == 4)
                    WriteLine(Divide());
                else if (n == 5)
                    System.Environment.Exit(0);
            }
            catch
            {
                WriteLine("Invalid Entry. Try Again.");
                Main();
            }
        }
    }
}
