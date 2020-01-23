using System;
using static System.Console;
using System.Linq;

namespace CalculatingAverages
{
    class Program
    {
        static string letterGrade(double average)
        {
            if (average < 90)
            {
                return "B";
            }
            else if (average < 80)
            {
                return "C";
            }
            else if (average < 70)
            {
                return "D";
            }
            else if (average < 60)
            {
                return "F";
            }
            else if (average <= 100)
            {
                return "A";
            }
            else
                return "Impossible";
        }
        static double ClassAverage(params int[] grades)
        {
            double total = grades.Sum();
            int numberOf = grades.GetLength(0);
            double findAverage = total / numberOf;
            return findAverage;
        }
        static void Main(string[] args)
        {
            WriteLine("---------------------------------");
            WriteLine("--------Calculate Average--------");
            WriteLine("---------------------------------");
            WriteLine("\n\nInput Numbers to Find Average:\n[Enter 'Done' When Complete]");
            var termsList = new System.Collections.Generic.List<int>();
            while (true)
            {
                try
                {
                    termsList.Add(Convert.ToInt32(ReadLine()));
                }
                catch
                {
                    int[] grades = termsList.ToArray();
                    ForegroundColor = ConsoleColor.Blue;
                    double average = ClassAverage(grades);
                    WriteLine("Your Average: " + average + "%" + "\nLetter Grade: " + letterGrade(average));
                    break;
                }
            }
        }
    }
}
