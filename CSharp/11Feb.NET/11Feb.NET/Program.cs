using CenterSpace.NMath.Stats;
using System;

namespace _11Feb.NET
{
    internal class Program
    {
        public struct moonStruct
        {
            public int x;
            public int y;
        }

        public enum Color { red = 1, white = 2, blue = 3 };

        public enum Months
        {
            January = 1,
            Feburary = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        public struct birthday
        {
            public int bday, byear;
            public Months bmonth;
        }

        private static void Main()
        {
            #region Q1
            //Q1
            moonStruct m1 = new moonStruct();
            m1.x = 15;
            m1.y = 25;
            int sum = m1.x + m1.y;
            Console.WriteLine("\nMoonstruct Sum: " + sum);
            #endregion

            #region Q2
            //Q2
            Console.WriteLine("\nWhich Color?\n1. Red\n2. White\n3. Blue");
            int b = Convert.ToInt32(Console.ReadLine());
            Color myColor = (Color)b;
            try
            {
                if (b > 3)
                {
                    Console.WriteLine("Invalid Entry");
                }
                switch (myColor)
                {
                    case Color.red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your color is red");
                        break;

                    case Color.white:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Your color is white");
                        break;

                    case Color.blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Your color is blue");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Entry");
            } 
            #endregion

            #region Q3
            Console.ForegroundColor = ConsoleColor.White;
            birthday myBirthday = new birthday();
            myBirthday.bday = 11;
            myBirthday.bmonth = (Months)12;
            myBirthday.byear = 1991;
            Console.WriteLine($"\nMy birthday is on {myBirthday.bmonth} {myBirthday.bday}, {myBirthday.byear}");
            #endregion

            #region Q4
            Console.WriteLine($"\nAuthor: {Author.Authorname}\nBook Name: {Author.Bookname}\nNumber of Pages: {Author.numPages}"); 
            #endregion

            #region Q5
            int[] pNumbers = { 2, 3, 5, 7, 11, 13, 17 };
            string[] names = { "Mickey", "Minnie", "Donald", "Daisy" };
            string[] names2 = { "Mickey", "Minnie", "Donald", "Daisy" };

            int pNumbersLength = pNumbers.Length;
            Console.WriteLine("\npNumb Length: " + pNumbersLength);
            int namesLength = names.Length;
            Console.WriteLine("\nnames Length: " + namesLength);

            int pNumThird = pNumbers[3];
            string namesThird = names[3];
            Console.WriteLine($"\nThird index of pNumbers is {pNumThird} and names is {namesThird}\n");

            for (int i = 0; i < 3; i++)
            {
                names2[i] = Convert.ToString(pNumbers[i]);
            }

            //array copy
            Console.WriteLine("\nFirst three copied to names");
            foreach (string i in names2)
            {
                Console.Write(i + " ");
            }

            //Array.Copy(pNumbers, 0, names, 0, 3);
            Array.Sort(names2);
            Array.Sort(pNumbers);

            Console.WriteLine("\npNumbers: ");
            foreach (int i in pNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nnames: ");
            foreach (string i in names)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n\nMean: " + StatsFunctions.Mean(pNumbers));
            Console.WriteLine("Max: " + StatsFunctions.MaxValue(pNumbers));
            Console.WriteLine("Min: " + StatsFunctions.MinValue(pNumbers));
            Console.WriteLine("Sum: " + StatsFunctions.Sum(pNumbers));
            Console.WriteLine("Median: " + StatsFunctions.Median(pNumbers));
            Console.WriteLine("Mode: " + StatsFunctions.Mode(pNumbers));
            Console.WriteLine("Standard Deviation: " + StatsFunctions.StandardDeviation(pNumbers));

            for (int i = 0; i < pNumbers.Length; i++)
            {
                if (pNumbers[i] == 11)
                {
                    Console.WriteLine($"\n\n11 is at index of {i}");
                }
                else
                    continue;
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Donald")
                {
                    Console.WriteLine($"Donald is at index of {i}");
                }
            } 
            #endregion
        }
    }
}