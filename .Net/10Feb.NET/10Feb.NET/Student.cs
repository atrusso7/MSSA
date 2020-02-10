using System;
using System.Collections.Generic;
using System.Text;

namespace _10Feb.NET
{
    class Student
    {
        public int id, age;
        public string name, subject;
        public Student(int id, string name, int age, string subject)
        {
            this.id = id;
            this.age = age;
            this.subject = subject;
            this.name = name;
        }
        public void showInfo()
        {
            Console.WriteLine("ID: " + id + "\nName: " + name + "\nAge: " + age + "\nSubject: " + subject);
        }
    }
}
