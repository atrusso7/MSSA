using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class StaticExtension
    {
        public static void M4(this ExtenstionSample e)
        {
            Console.WriteLine("M4");
        }
        public static void M5(this ExtenstionSample e, string str)
        {
            Console.WriteLine(str);
        }
    }
}
