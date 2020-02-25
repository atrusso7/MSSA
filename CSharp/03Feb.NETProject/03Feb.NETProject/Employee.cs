using System;
using System.Collections.Generic;
using System.Text;

namespace _03Feb.NETProject
{
    class Employee
    {
        private int hoursWorked, hourRate;
        private string name;
        public int HoursWorked
        {
            get => hoursWorked;
            set => hoursWorked = value;
        }
        public int HoursRate
        {
            get => hourRate;
            set => hourRate = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int CalculatePay()
        {
            int total = HoursWorked * HoursRate;
            return total;
        }
        public int CalculatePay(int bonus, int allowance)
        {
            int total = (HoursWorked * HoursRate) + bonus + allowance;
            return total;
        }
        public override string ToString()
        {
            return "\nTo String Method\nName: " + Name + "\nHour Rate: " + HoursRate + "\nHours Worked: " + HoursWorked;
        }
        public Employee(string FirstName)
        {
            Console.WriteLine("Name: " + FirstName);
        }
        public Employee(string FirstName, string LastName)
        {
            Console.WriteLine("\nConstructor Method\nFirst Name: " + FirstName + "\nLast Name: " + LastName);
        }
    }
}
