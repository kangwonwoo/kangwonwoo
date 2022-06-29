﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 강원우
 * 내용 : [총정리 문제] 배열과 메서드
 */
namespace Test.총정리2
{
    internal class L2_01
    {
        static void Main1(string[] args)
        {
            int[] arr1 = { 5, 25, 75, 35, 15 };
            PrintArray(arr1);

            int[] arr2 = (int[])arr1.Clone();
            PrintArray(arr2);

            int[] arr3 = new int[10];
            arr1.CopyTo(arr3, 3);
            PrintArray(arr3);

            Array.Sort(arr1);
            PrintArray(arr1);

            Array.Reverse(arr1);
            PrintArray(arr1);
        }

        public static void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine("{0,5}", i);
            }
            Console.WriteLine();
        }
    }
}
