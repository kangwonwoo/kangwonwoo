﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/21
 * 이름 : 강원우
 * 내용 : 델리게이트 실습하기 교재 p493
 * 
 * 대리자(Delegate)
 * - 대리자는 메서드에 대한 참조를 나타내는 형식으로 메서드를 대신 호출 해주는 역할
 * - 대ㅣ자를 익명 메서드로 많이 활용한다.
 */
namespace Ch09
{
    //  대리자 선언
    public delegate int MyDelegate(int x, int y);
    public delegate int SumDelegate(int[] arr);

    internal class _1_Delegate
    {
        static void Main1(string[] args)
        {
            //  대리자 초기화(메서드 참조)
            MyDelegate my1 = new MyDelegate(Plus);
            MyDelegate my2 = new MyDelegate(Minus);

            int r1 = my1(1, 2);
            int r2 = my2(1, 2);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);

            //  대리자 활용(메서드의 매개변수로 대리자 선언)
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int rs1 = Sum(arr, OddSum);   //  행위(메서드)를 전달하기 위해 대리자 사용 
            int rs2 = Sum(arr, EvenSum);

            //  대리자를 익명 메서드로 활용
            var md = delegate (int x, int y) { 
                return x * y;
            };

            int result1 = md(2, 3);
            int result2 = md(3, 4);

            Console.WriteLine("result1 : "+result1);
            Console.WriteLine("result2 : "+result2);

            //  익명 메서드를 매개변수로 갖는 컬렉션 메서드
            List<int> dataset = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //  Foreach : 반복처리
            dataset.ForEach(delegate (int n) {
                Console.Write(n+" ");
            });

            Console.WriteLine();

            foreach(int n in dataset)
            {
                Console.Write(n+" ");
            }
        }

        public static int Plus(int x, int y)
        {
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            return x - y;
        }

        public static int OddSum(int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                if (n % 2 == 1)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public static int EvenSum(int[] arr)
        {
            int sum = 0;

            foreach (int n in arr)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public static int Sum(int[] arr, SumDelegate sumDelegate)  //  매개변수 델리게이트 선언(sumDelegate)
        {
            return sumDelegate(arr);
        }

    }
}
