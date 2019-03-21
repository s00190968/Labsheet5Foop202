using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 343, 4, 45, 65, 6, 43, 43, 34, 45, 76, 7, 543, 9, 7, 8, 3, 5, 64, 4, 3 };

            var query = nums.OrderByDescending(n => n);
            var q2 = query.Where(n => n < 8);
            var q3 = q2.Select(n => DoubleIt(n));

            Console.WriteLine("Query 3:");

            foreach(var item in q3)
            {
                Console.WriteLine(item);
            }

            var q4 = nums.OrderByDescending(n => n).Where(n => n < 8).Select(n => DoubleIt(n));

            Console.WriteLine("Query 4: ");

            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static object DoubleIt(int n)
        {
            return n * 2;
        }
    }
}
