using System;

namespace _03Feb.NETProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Employee e1 = new Employee("Mickey", "Mouse")
            {
                Name = "Mickey Mouse",
                HoursRate = 20,
                HoursWorked = 40
            };
            Employee e2 = new Employee("Shrek")
            {
                Name = "Shrek",
                HoursRate = 25,
                HoursWorked = 50
            };
            //Mickey
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMain Method\nName: " + e1.Name + "\nHourly Rate: " + e1.HoursRate + "\nHours Worked: " +
                e1.HoursWorked + "\nTotal Pay (Allowance: 0, Bonus: 0): " + e1.CalculatePay());
            //Shrek
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMain Method\nName: " + e2.Name + "\nHourly Rate: " + e2.HoursRate + "\nHours Worked: " +
                e2.HoursWorked + "\nTotal Pay (Allowance: 350, Bonus: 150): " + e2.CalculatePay(350, 150));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(e1.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(e2.ToString());
        }
    }
}
