﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/10
 * 이름 : 강원우
 * 내용 : 배열 연습문제
 */
namespace Test._2
{
    internal class _2_02
    {
        static void Main2(string[] args)
        {
            int[] arr = { 17, 92, 18, 33, 58, 7, 26, 42 };

            int maxNum = arr[0];

            for(int i = 0; i < 8; i++)
            {
                if(maxNum < arr[i])
                {
                    maxNum = arr[i];
                }
            }
            Console.WriteLine("배열 arr에서 가장 큰 수 : "+ maxNum);
        }
    }
}
