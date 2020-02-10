using System;
using System.Collections.Generic;
using System.Text;

namespace _10Feb.NET
{
    struct MyStruct
    {
        private int x, y;
        private AnotherClass myStruct;
        DayOfWeek myDays;

        public MyStruct(int a, int b, int c)
        {
            myStruct = new AnotherClass();
            myStruct.number = a;
            x = b;
            y = c;
            myDays = DayOfWeek.Friday;
        }
        public void PrintStatement()
        {
            Console.WriteLine("x = " + x + "\ny = " + y + "\nDay: " + myDays);
        }
    }
}
