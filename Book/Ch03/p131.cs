﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p131
    {
        static void Main131(string[] args)
        {
            if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            else
            {
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
