﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p396
    {
        // 제네릭기본
        class Wanted<T>
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }

        class Program
        {
            static void Main396(string[] args)
            {
                Wanted<string> wantedString = new Wanted<string>("String");
                Wanted<int> wantedInt = new Wanted<int>(52273);
                Wanted<double> wantedDouble = new Wanted<double>(52.273);

                Console.WriteLine(wantedString.Value);
                Console.WriteLine(wantedInt.Value);
                Console.WriteLine(wantedDouble.Value);
            }
        }
    }
}
