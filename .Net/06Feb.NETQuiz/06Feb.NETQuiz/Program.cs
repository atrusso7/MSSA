using System;
using System.Collections.Generic;

namespace _06Feb.NETQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            demoRefValue quiz = new demoRefValue();
            List<int> b = new List<int> { 11, 21, 31, 41, 51 };
            b[0] = 10;
            Console.WriteLine("Before method b[0] = " + b[0]);
            quiz.PassByRefPara(b);
            b[0] = 5;
            Console.WriteLine("After method b[0] = " + b[0]);
        }
    }
}
