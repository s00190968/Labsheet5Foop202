using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,5,23,4,5,3,56,7,67,33,6,89,5,3,2 };

            var outputNums = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach(int n in outputNums)
            {
                Console.WriteLine("Number: " + n);
            }
            Console.ReadKey();
        }
    }
}
