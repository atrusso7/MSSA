using System;
using System.Collections.Generic;
using System.Threading;

namespace _27Feb_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var red = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            var black = new List<int> { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            var list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[   ~ Welcome to Roulette ~   ]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("How many rolls would you like?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rolling...");
            Thread.Sleep(3000);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(list.Count);
                if (red.Contains(index))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{index} Red");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (black.Contains(index))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{index} Black");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{index} Green");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
