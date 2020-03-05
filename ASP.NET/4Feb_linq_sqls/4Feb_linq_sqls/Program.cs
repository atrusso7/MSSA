using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Feb_linq_sqls
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext a = new DataClasses1DataContext();
            IEnumerable<Customer> b = a.Customers;
            foreach(Customer i in b.Take(5))
            {
                Console.WriteLine(i.ContactName);

            }
        }
    }
}
