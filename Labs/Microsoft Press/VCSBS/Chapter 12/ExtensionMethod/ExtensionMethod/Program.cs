using Extensions;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            int x = 591;
            for(int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }
        static void Main()
        {
            ExtenstionSample e = new ExtenstionSample();
            e.M1();
            e.M2();
            e.M3();
            e.M4();
            e.M5("M5");
        }
    }
}
