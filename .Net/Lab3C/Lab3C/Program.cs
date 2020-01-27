using System;
using static System.Console;

namespace Lab3C
{
    class Program
    {
        static int TuitionIncrease(int b)
        {
            double newTotal = b * .02;
            return (int)newTotal;
        }
        static int Tuition(int n)
        {
            int baseCost = 6000;
            int total = 6000;
            int nYearTotal = 6120;
            for(int i = n; i >= 1; i--)
            {
                total = baseCost + TuitionIncrease(baseCost);
                baseCost = total;
                WriteLine(i + " Year = $" + total);
                if (i > 1)
                {
                    nYearTotal += baseCost;
                }
            }
            return nYearTotal;
        }
        static int Feet2Inch(int n)
        {
            int total = n * 12;
            return total;
        }
        static void GreaterLesser(int n1, int n2)
        {
            if (n1 > n2)
            {
                WriteLine(n1 + " is Greater Than " + n2);
            }
            else if (n1 == n2)
            {
                WriteLine(n1 + " is Equal to " + n2);
            }
            else
                WriteLine(n1 + " is Lesser Than " + n2);
        }
        static void Main(string[] args)
        {
            //calculate tuition increase
            WriteLine("Calculate Tuition Increase");
            WriteLine("Base Tuition: [$6000] Annual Increase:[2%]");
            WriteLine("Enter Years");
            int n = Convert.ToInt32(ReadLine());
            Clear();
            WriteLine("For " + n + " year(s) tuition will be [$" + Tuition(n) + "]\n\n");
            //convert feet to inches
            WriteLine("Convert Feet to Inches\nEnter Feet: ");
            int feet = Convert.ToInt32(ReadLine());
            WriteLine(feet + " Feet is " + Feet2Inch(feet) + " Inches\n\n");
            //Decide if a number is greater or lesser between two numbers
            WriteLine("Find if a Number is Greater or Lesser\nEnter First Number: ");
            int n1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter Second Number: ");
            int n2 = Convert.ToInt32(ReadLine());
            GreaterLesser(n1, n2);
        }
    }
}
