using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p301
    {
        // 값 복사와 참조 복사 : int/float 등 기본 자료형은 값이고,
        //                      클래스로 만들어진  인스턴스(객체)는 참조이다.

        // 기본 자료형 : 메모리에 4바이트 영역을 잡고 값이 들어감
        static void Main301(string[] args)
        {
            int a = 10;

            // 객체 자료형 : 인스턴스를 생성하면 힙(heap) 영역에 위치를 잡고 주소값이 변수 a에 들어감
            Random a1 = new Random();
        }
    }
}
