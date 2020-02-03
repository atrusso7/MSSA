using System;
using System.Collections.Generic;
using System.Text;

namespace _03Feb.NET
{
    class deptEmployee //using a field, a variable that is declared inside a class
    {
        public int id;
        public string name;
        public string department;

        public void InsertData(int ID, String Name, string Department)
        {
            id = ID;
            name = Name;
            department = Department;
        }
        public void DisplayData()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Department: " + department);
        }
    }
}
