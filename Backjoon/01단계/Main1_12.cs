﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._01단계
{
    internal class Main1_12
    {
        static void Main12(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);
            int n3 = int.Parse(num[2]);

            Console.WriteLine((n1 + n2) % n3);
            Console.WriteLine(((n1 % n3) + (n2 % n3)) % n3);
            Console.WriteLine((n1 * n2) % n3);
            Console.WriteLine(((n1 % n3) * (n2 % n3)) % n3);

        }
    }
}
