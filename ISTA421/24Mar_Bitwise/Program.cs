using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Mar_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            //binary for 5 = 0101
            int a = 5;
            //binary for 7 = 0111
            int b = 7;            
            int c = 0;

            c = a & b;             
            Console.WriteLine($"[&] Value of c is {c}");

            c = a | b;             
            Console.WriteLine($"[|] Value of c is {c}");

            c = a ^ b;             
            Console.WriteLine($"[^] Value of c is {c}");

            c = ~a;                
            Console.WriteLine($"[~] Value of c is {c}");

            c = a << 2;      
            Console.WriteLine($"[<<] Value of c is {c}");

            c = a >> 2;      
            Console.WriteLine($"[>>] Value of c is {c}");
            Console.ReadLine();
        }
    }
}
