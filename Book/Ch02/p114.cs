﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p114
    {
        static void Main114(string[] args)
        {
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));

            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
        }
    }
}
