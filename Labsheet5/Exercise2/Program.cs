using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = files.Where(f => f.Length < 1000).OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new FileInfo
                {
                    Name = f.Name,
                    Length = files.Length,
                    CreationTime = f.CreationTime
                });

            Console.WriteLine("{0,0}{1,20}{2,40}", "Name", "Length", "Creation date");

            foreach(var item in query)
            {
                Console.WriteLine("{0,0}{1,20}{2,40}", item.Name,item.Length,item.CreationTime.ToShortDateString());
            }

            Console.ReadKey();
        }
    }
}
