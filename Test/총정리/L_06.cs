﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/27
 * 이름 : 강원우
 * 내용 : [총정리 문제] 문자열
 */
namespace Test.총정리
{
    internal class L_06
    {
        static void Main6(string[] args)
        {
            string s = " Hello, World! ";

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8, "C# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Substring(0, 6));  //  reomve(6)도 가능
            Console.WriteLine(s.Remove(6, 7));
            Console.WriteLine(s.Replace('1', 'm'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');

            Console.WriteLine(s.Substring(8));
            Console.WriteLine(s.Substring(8, 5));

            Console.WriteLine(string.Concat("Hi~", s));

            string[] val = { "apple", "orange", "grape" };
            string result = string.Join(",", val);
            Console.WriteLine(result);
        }
    }
}
