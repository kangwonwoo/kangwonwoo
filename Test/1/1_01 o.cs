﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 강원우
 * 내용 : 자료형 연습문제
 */
namespace Test._1
{
    internal class _1_01
    {
        static void Main01(string[] args)
        {
            char var1 = 'A';           //var1 ~ 7 까지는 원시타입
            int var2 = 100;
            long var3 = 2147483648L;
            float var4 = 3.14f;
            double var5 = 3.14159;
            bool var6 = true;
            bool var7 = false;
            string var8 = "hello";
            string var9 = null;    // object 가능

            Console.WriteLine("var1 : " + var1);
            Console.WriteLine("var2 : " + var2);
            Console.WriteLine("var3 : " + var3);
            Console.WriteLine("var4 : " + var4);
            Console.WriteLine("var5 : " + var5);
            Console.WriteLine("var6 : " + var6);
            Console.WriteLine("var7 : " + var7);
            Console.WriteLine("var8 : " + var8);
            Console.WriteLine("var9 : " + var9);
        }
    }
}
