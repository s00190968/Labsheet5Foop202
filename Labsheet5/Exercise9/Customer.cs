using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name}, {City}");
        }
    }
}
