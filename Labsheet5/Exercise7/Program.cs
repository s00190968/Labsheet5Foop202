using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var q1 = names.OrderByDescending(n => n).Reverse();

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
