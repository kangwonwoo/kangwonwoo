﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p139
    {
        static void Main139(string[] args)
        {
            // 변수를 선언합니다.
            Console.WriteLine("숫자를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());

            // 조건문
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }
        }
    }
}
