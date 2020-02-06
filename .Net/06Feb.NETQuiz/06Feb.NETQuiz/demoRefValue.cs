using System;
using System.Collections.Generic;
using System.Text;

namespace _06Feb.NETQuiz
{
    class demoRefValue
    {
        public void PassByRefPara(List<int> b)
        {
            b[0] = 5;
            Console.WriteLine("Inside method b[0] = " + b[0]);
        }
    }
}
