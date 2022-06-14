using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p406
    {
        // 구조체의 생성자

        // 구조체에 매개변수 없는 생성자는 선언 불가
        struct Point
        {
            public int x;
            public int y;

            // public Point()  --> 오류 발생
            //{

            //}
        }

        // 구조체의 생성자
        struct Point1
        {
            public int x;
            public int y;

             public Point1(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
