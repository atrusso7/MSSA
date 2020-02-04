using System;

namespace _04Feb.NET
{
    class Program
    {
        static void doIncrement(int param)
        {
            param++;
        }
        static void doRefIncrement(ref int param) // using ref
        {
            param++;
        }
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Employee e1 = new Employee("Mickey", "Mouse")
            //{
            //    Name = "Mickey Mouse",
            //    HoursRate = 20,
            //    HoursWorked = 40,
            //};
            //Employee e2 = new Employee("Shrek")
            //{
            //    Name = "Shrek",
            //    HoursRate = 25,
            //    HoursWorked = 50
            //};
            ////Mickey
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\nMain Method\nName: " + e1.Name + "\nHourly Rate: " + e1.HoursRate + "\nHours Worked: " +
            //    e1.HoursWorked + "\nTotal Pay (Allowance: 0, Bonus: 0): " + e1.CalculatePay());
            ////Shrek
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("\nMain Method\nName: " + e2.Name + "\nHourly Rate: " + e2.HoursRate + "\nHours Worked: " +
            //    e2.HoursWorked + "\nTotal Pay (Allowance: 350, Bonus: 150): " + e2.CalculatePay(350, 150));

            
            //int arg = 42;
            //doIncrement(arg);
            //Console.WriteLine(arg); // writes 42, not 43

            //int arg2 = 42;
            //doRefIncrement(ref arg2); // using ref
            //Console.WriteLine(arg2); // writes 43

            int a = 2;
            int[] b = { 1, 2, 3 };

            demoRefValue t = new demoRefValue();
            Console.WriteLine("A before = " + a);
            t.PassByValue(a);
            Console.WriteLine("\nA after = " + a);
            t.PassByRef(b);
        }
    }
}
