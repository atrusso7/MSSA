using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace _14Apr_IEnumerator
{
    public class Employee
    {
        public string name { get; set; }
        public string position { get; set; }
    }
    public class Employees : IEnumerable
    {
        ArrayList employees = new ArrayList();
        public void AddEmployee (Employee e)
        {
            employees.Add(e);
        }
        public Employee GetEmployee(int Position)
        {
            return (Employee)employees[Position];
        }
        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
    }
    public class EmployeeList<T> : IEnumerable<T>
    {
        List<T> eList = new List<T>();
        public void AddEmployee (T e)
        {
            eList.Add(e);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return eList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Non-Generic Method using foreach
            var Studio = new Employees();
            Studio.AddEmployee(new Employee()
            {
                name = "Brad Pitt",
                position = "Actor"
            });
            Studio.AddEmployee(new Employee()
            {
                name = "Matt Damon",
                position = "Actor"
            });
            Studio.AddEmployee(new Employee()
            {
                name = "Christopher Nolan",
                position = "Director"
            });
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Studio Employees] ***Non-Generic Method");
            Console.ResetColor();
            foreach (Employee e in Studio)
            {
                Console.WriteLine($"Name: {e.name}\nPosition: {e.position}\n");
            }

            //Generic Method using enumerator
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Studio Employees] ***Generic Method");
            Console.ResetColor();
            var genEmployees = new EmployeeList<Employee>();
            genEmployees.AddEmployee(new Employee()
            {
                name = "Brad Pitt",
                position = "Actor"
            });
            genEmployees.AddEmployee(new Employee()
            {
                name = "Matt Damon",
                position = "Actor"
            });
            genEmployees.AddEmployee(new Employee()
            {
                name = "Christopher Nolan",
                position = "Director"
            });
            var genShow = genEmployees.GetEnumerator();
            while (genShow.MoveNext())
            {
                Console.WriteLine($"Name: {genShow.Current.name}\nPosition: { genShow.Current.position}\n");
            }
            Console.ReadLine();
        }
    }
}
