﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p210
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);
            Console.WriteLine(random.NextDouble() * 10);

            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
        }
    }
}
