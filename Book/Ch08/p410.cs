using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p410
    {
        // 구조체에서 클래스 인스턴스를 멤버 변수로 선언
        class Program
        {
            struct Point
            {
                public int x;
                public int y;

                public Point(int x, int y)
                {
                    this.x = x;
                    this.y = y;
                    //this.program = null;
                }
            }
        }
    }
}
