﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p191
    {
        static void Main191(string[] args)
        {
            int i = 10;
            while (i --> 0)
            {
                Console.WriteLine(i);
            }

            int i2 = 10;
            while ((i--) > 0)
            {
                Console.WriteLine(i2);
            }
        }
    }
}
