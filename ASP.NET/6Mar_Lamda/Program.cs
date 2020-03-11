using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Mar_Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var result = db.Customers.Join(db.Orders, c => c.CustomerID, o => o.CustomerID, (c, o) => new { c.ContactName, o.OrderDate });
            foreach (var pair in result.Take(5))
                Console.WriteLine(pair.ContactName + " " + pair.OrderDate);

            Console.WriteLine("\nLamda Method: ");
            var result1 = db.Orders
                .Join(db.Employees, o => o.EmployeeID, e => e.EmployeeID, (o, e) => new { e.LastName, o.ShipCountry, o.CustomerID })
                .Join(db.Customers, o => o.CustomerID, c => c.CustomerID, (o, c) => new { o.LastName, c.ContactName, o.ShipCountry });
            foreach(var pair in result1.Take(5))
                if(pair.ShipCountry == "France")
                    Console.WriteLine(pair.LastName + " | " + pair.ContactName + " | " + pair.ShipCountry);

            Console.WriteLine("\nEntity Method: ");
            var result2 = (from o in db.Orders.Take(5)
                           join e in db.Employees on o.EmployeeID equals e.EmployeeID
                           join c in db.Customers on o.CustomerID equals c.CustomerID
                           where o.ShipCountry == "France"
                           select new { e.LastName, c.ContactName, o.ShipCountry });
            foreach (var item in result2)
                Console.WriteLine(item.LastName + " | " + item.ContactName + " | " + item.ShipCountry);

            Console.WriteLine("\nNavigation Property Method: ");
            foreach(Order o in db.Orders.Take(5))
                if (o.ShipCountry == "France")
                    Console.WriteLine(o.Employee.LastName + " | " + o.Customer.ContactName + " | " + o.ShipCountry);

        }
    }
}
