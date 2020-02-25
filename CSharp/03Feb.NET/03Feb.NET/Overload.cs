using System;
using System.Collections.Generic;
using System.Text;

namespace _03Feb.NET
{
    class Overload
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }
}
