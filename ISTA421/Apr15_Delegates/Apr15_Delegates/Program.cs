using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Apr15_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            DelMethod D1 = DelP.Show;
            DelMethod D2 = new DelMethod(DelP.Display);
            DelMethod D3 = new DelMethod(DelP.Print);
            D1();
            D2();
            D3();
            
            //Part 2
            AddNum a1 = SumSub.Sum;
            SubNum s1 = SumSub.Subtract;
            s1(5, 10);
            a1(5, 10);
            Console.ReadLine();
        }
        public delegate void DelMethod();

        public delegate void AddNum(int a, int b);

        public delegate void SubNum(int a, int b);

        class DelP
        {
            public static void Display()
            {
                Console.WriteLine("Display");
            }

            public static void Show()
            {
                Console.WriteLine("Show");
            }

            public static void Print()
            {
                Console.WriteLine("Print");
            }
        }
    }

    class SumSub
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}