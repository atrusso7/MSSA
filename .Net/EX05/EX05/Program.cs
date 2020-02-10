using System;

namespace EX05
{
    class Program
    {
        static int[] SortedArray(int[] a)
        {
            Array.Sort(a);
            Console.WriteLine("\nSorted Array: ");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            return a;
        }
        static int[] UnsortedArray(int[] a)
        {
            Console.WriteLine("Unsorted Array: ");
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] a = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            UnsortedArray(a);
            SortedArray(a);
        }
    }
}
