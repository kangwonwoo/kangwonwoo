﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/23
 * 이름 : 강원우
 * 내용 : 컬렉션 연습문제
 */
namespace Test._5
{
    internal class _5_01
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int> { 3, 6, 2, 2, 2, 7 };

            HashSet<int> hset = new HashSet<int>(list);
            SortedSet<int> sset = new SortedSet<int>(hset);
            Stack<int> stack = new Stack<int>(sset);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
