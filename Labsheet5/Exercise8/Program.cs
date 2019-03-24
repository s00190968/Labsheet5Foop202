using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var q1 = names.Select(n => n).Where(n => n.Contains("M"));

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
