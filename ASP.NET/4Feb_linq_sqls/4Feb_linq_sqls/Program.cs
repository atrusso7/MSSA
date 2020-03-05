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
            #region entity framework
            DataClasses1DataContext db = new DataClasses1DataContext();
            var selectItem = db.Customers.First();
            Console.WriteLine(selectItem.ContactName);
            foreach (Order o in selectItem.Orders)
                Console.WriteLine("\t" + o.OrderDate);
            
            Console.WriteLine();
            var selectCompany = db.Suppliers.First();
            Console.WriteLine(selectCompany.CompanyName);
            foreach(Product p in selectCompany.Products)
                Console.WriteLine("\t" + p.ProductName);

            Console.WriteLine();
            foreach(Supplier s in db.Suppliers.Take(5))
            {
                Console.WriteLine(s.CompanyName);
                foreach(Product p in s.Products)
                    Console.WriteLine("\t" + p.ProductName);
            }
            Console.WriteLine();
            var query = from Product in db.Products.Take(5)
                        select new
                        {
                            Product.Supplier.CompanyName,
                            Product.ProductName
                        };
            var productSupplier = query.ToList();
            foreach (var item in productSupplier)
                Console.WriteLine(item);

            Console.WriteLine();
            var query1 = from order in db.Orders.Take(5)
                         select new
                         {
                             order.OrderDate,
                             order.Employee.City
                         };
            var dateCity = query1.ToList();
            foreach( var item in dateCity)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var query2 = from order in db.Orders.Take(5)
                         select new
                         {
                             order.OrderDate,
                             order.Customer.ContactName,
                             order.Employee.City
                         };
            var query2Result = query2.ToList();
            foreach (var item in query2Result)
                Console.WriteLine(item);
            Console.WriteLine();

            var query3 = from Product in db.Products.Take(5)
                         select new
                         {
                             Product.Category.CategoryName,
                             Product.Supplier.CompanyName,
                             Product.ProductName
                         };
            var query3List = query3.ToList();
            foreach(var item in query3List)
                Console.WriteLine(item);
            Console.WriteLine();

            List<Customer> customers = new List<Customer>();
            Console.WriteLine("Alan" + " 9999999" + " ABC Street " + -25.60m );
            #endregion
        }
        #region sealed class
        
        #endregion
    }
}
