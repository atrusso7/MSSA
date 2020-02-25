using System;
using System.Collections.Generic;
using System.Text;

namespace _04Feb.NET
{
    class demoRefValue
    {
        public void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine("A Inside Method = " + a);
        }
        public void PassByRef(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] Inside Method = " + b[0]);
        }
    }
}
