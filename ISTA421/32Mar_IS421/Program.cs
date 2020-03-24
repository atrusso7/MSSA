using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Mar_IS421
{
    class Person
    {
        private int _age;
        private string _name;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Age cannot be negative");
                }
                this._age = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person c1 = new Person();
            Console.Write("Age: ");
            c1.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nName: ");
            c1.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Your age is : {0}", c1.Age);
            Console.WriteLine("Your Name is : {0}", c1.Name);
        }

    }
}

