using System;
using System.Collections.Generic;
using System.Text;

namespace _03Feb.NETTest
{
    class Staff
    {
        const int hourlyRate = 15;
        int hWorkedOverTime;
        public int HoursWorked { get; set; }
        public double CalculateOvertimePay(int overtime)
        {
            double total = overtime * 1.5;
            return total;
        }
        public Staff(string name)
        {
            Console.WriteLine(name);
        }
    }
}
