using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p291
    {
        // 상수 생성 : 변수 or 속성 앞에 const 키워드를 붙여준다.
        class MyMath
        {
            public const double PI = 3.141592;
        }


        // 메서드 내부에서 상수 사용
        static void Main291(string[] args)
        {
            const int value = 10;

            Console.WriteLine(value);
        }
    }
}
