using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Mar_properties
{
    public class Triangle
    {
        private int _side1 = 10;
        private int _side2 = 10;
        private int _side3 = 10;
        public int Side1 { get => _side1; set => _side1 = value; }
        public int Side2 { get => _side2; set => _side2 = value; }
        public int Side3 { get => _side3; set => _side3 = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Triangle()
            {
                Side1 = 9,
                Side2 = 12,
                Side3 = 15
            };
            Console.WriteLine($"Side 1 Length: {t1.Side1}\nSide 2 Length: {t1.Side2}\nSide 3 Length: {t1.Side3}");
        }
    }
}
