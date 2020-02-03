using System;
using System.Collections.Generic;
using System.Linq;

namespace Test3
{
    class Program
    {
        static bool PerfectNumber(int n)
        {
            List<int> roots = new List<int>();
            IEnumerable<int> range = Enumerable.Range(1, n - 1);
            foreach (int num in range)
            {
                int mod = (n % num);
                if (mod == 0)
                {
                    roots.Add(num);
                }
            }
            int sum = roots.Sum(x => Convert.ToInt32(x));
            if (sum == n)
                return true;
            else
                return false;
        }
        static void Main()
        {
            //Perfect number test
            Console.WriteLine("Check if perfect number\nEnter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PerfectNumber(n));

            //Test 3
            try
            {
                int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter index: ");
                int index = Convert.ToByte(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nIndex " + index + " is [" + myArray[index] + "]");
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Main();
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Main();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Main();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Main();
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Error handling complete");
            }
        }
    }
}
