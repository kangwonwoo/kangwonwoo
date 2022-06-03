using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p95
    {
        static void Main95(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);

            int num = 10;
            Console.WriteLine(num);
            Console.WriteLine(num); num += 1;
            Console.WriteLine(num); num -= 1;
            Console.WriteLine(num);
        }
    }
}
