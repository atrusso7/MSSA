using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfectNumber
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
        Console.WriteLine("Check if perfect number\nEnter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PerfectNumber(n));
        PerfectNumber(10);
    }
}
