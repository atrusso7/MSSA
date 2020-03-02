using System;
using System.Collections.Generic;
using System.Text;

namespace _25Feb
{
    public class Overload
    {
        public int PlusMethod(int x, int y)
        {
            int total = x + y;
            return total;
        }
        public double PlusMethod(double x, double y)
        {
            double total = x + y;
            return total;
        }
    }
}
