using System;

namespace _27Jan.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//foreach loop
            char[] myArray = { 'T', 'e', 'r', 'e', 'n', 'c', 'e' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }*/

           /* //while loop
            int counter = 0; 
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }*/

            //create array called gender to display male and female
            char[] genderArray = { 'm', 'f', 'm', 'f', 'f', 'f', 'f' };
            int males = 0;
            int females = 0;
            char male = 'm';
            char female = 'f';
            foreach(char ch in genderArray)
            {
                if (ch == 'm')
                {
                    males++;
                }
                else if(ch == 'f')
                {
                    females++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( Convert.ToString(males) + " male(s)");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Convert.ToString(females) + " female(s)");
        }
    }
}
