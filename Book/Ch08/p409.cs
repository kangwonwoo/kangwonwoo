﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p409
    {
        // 구조체의 초기화 형태
        // 구조체의 초기화 형태
        struct  Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;   

            public Point (int x, int y)     // 생성자 오버로딩
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            //public Point(int x, int y, string test)  // 생성자 오버로딩
            //{
            //    this.x = x;
            //    this.y = y;
            //    this.testA= test;
            //    this.testA = test;
            //}
        }
    }
}
