﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p408
    {
      // 구조체는 생성자에서 모든 변수를 초기화해야 함
      //struct  Point
       // {
            public int x;
            public int y;
            public string testA;            // 초기화되지 않은 멤버 변수이므로 생성자를 만든다면, 생성자에서 반드시 초기화해줘야 함
            public string testB = "int t";  // 선언과 동시에 초기화 할 수 없습니다. 오류 발생

            //public Point (int x, int y)     // Point -> 멤버 변수 testA를 초기화하지 않았으므로, 오류 발생
            //{
            //    this.x = x;
            //    this.y = y;
            //}
       // }
    }
}
