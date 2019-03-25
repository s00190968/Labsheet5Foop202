using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {

            var query = GetCustomers().Select(n => n).Where(n => n.City.Contains("Dublin"));

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
        private static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Tom", City = "Dublin" });
            customers.Add(new Customer { Name = "Sally", City = "Galway" });
            customers.Add(new Customer { Name = "George", City = "Cork" });
            customers.Add(new Customer { Name = "Molly", City = "Dublin" });
            customers.Add(new Customer { Name = "Joe", City = "Galway" });
            customers.Add(new Customer { Name = "Coldsteel The Hedgeheg", City = "Dublin" });

            return customers;
        }
    }
}
