﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/24
 * 이름 : 강원우
 * 내용 : 람다식 연습문제
 */
namespace Test._6
{
    internal class _6_05
    {
        static void Main5(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int n1 = Count(arr, delegate (int x) { return x % 2 == 1; });  // = Count(arr, x => x % 2 == 1);
            int n2 = Count(arr, delegate (int x) { return x % 2 == 0; });  // = Count(arr, x => x % 2 == 0);

            Console.WriteLine("홀수 갯수 : "+n1);
            Console.WriteLine("짝수 갯수 : "+n2);
        }

        public static int Count(int[] arr, Func < int, bool > my)
        {
            int cnt = 0;

            foreach(int n in arr)
            {
                if(my(n))
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
