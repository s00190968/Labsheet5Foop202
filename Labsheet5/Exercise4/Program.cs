using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 32, 34, 435, 32, 3243, 5464, 23, 221, 35, 56, 57, 7, 643, 52, 2, 35, 67 };

            var query = nums.Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("Doubling the value");
            return value * 2;
        }
    }
}
