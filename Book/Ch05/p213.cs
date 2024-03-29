﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p213
    {
        static void Main213(string[] args)
        {
            // 변수를 선언합니다.
            List<int> list = new List<int>();

            // 리스트에 요소를 추가합니다.
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            // 반복을 수행합니다.
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\nitem: " + item);
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);


                // 인스턴스 생성과 동시에 요소 추가
                List<int> l = new List<int>() { 52, 273, 32, 64 };

                // 반복을 수행합니다.
                foreach (var i in l)
                {
                    Console.WriteLine("Count: " + l.Count + "\nitem: " + i);
                    Console.WriteLine("Count: " + l.Count + "\titem: " + i);
                }
            }
        }
    }
}
