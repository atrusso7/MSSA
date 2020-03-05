using System;
using System.Linq;

namespace _4Feb_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linq
            Console.WriteLine("String []");
            string[] language = { "C#", "VB", "Java", "C++", "C", "PERL", "Ruby", "Python" };
            var result = from lang in language
                         where lang.Contains('C')
                         select lang;
            foreach (var l in result)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine("\n\nInt []");
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            var r = from n in numbers
                    where n % 2 == 0
                    select n;
            foreach (var n in r)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine(); 
            #endregion
        }
    }
}
