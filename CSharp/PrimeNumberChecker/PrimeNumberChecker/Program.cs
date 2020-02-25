using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n[Even or Odd]\nEnter Number: ");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                n = n % 2;
                if (n != 0)
                {
                    Console.WriteLine("Odd");
                    Main();
                }
                else
                {
                    Console.WriteLine("Even");
                    Main();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
