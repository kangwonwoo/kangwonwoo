using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p296
    {
        // 겟터와 셋터
        class Box
        {
            // 변수
            private int width;
            private int height;

            // 생성자
            public Box(int width, int height)
            {
                if (width > 0 || height > 0)
                {
                    this.width = width;
                    this.height = height;
                }
                else { Console.WriteLine("너비와 높이는 자연수로 초기화 해주세요!"); }
            }

            // 인스턴스 메서드
            public int Area() { return this.width * this.height; }

            // 겟터(Getter)
            public int Getwidth() { return width; }
            public int Getheight() { return height; }

            // 셋터(Setter)
            public void Setwidth(int width)
            {
                if(width > 0) { this.width = width; }
                else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
            }

            public void Setheight(int height)
            {
                if (height > 0) { this.height = height; }
                else { Console.WriteLine("높이는 자연수를 입력해주세요"); }
            }
        }
    }
}
