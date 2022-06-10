using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p285
    {
        // private 생성자 : 클래스의 인스턴스를 만들 수 없게 한다.
        class Program
        {
            class Hidden
            {
                public Hidden() { } // private을 사용하면 오류가 발생한다.
            }

            static void Main285(string[] args)
            {
                Hidden hidden = new Hidden(); // 오류발생
            }
        }
    }
}
