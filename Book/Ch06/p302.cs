using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p302
    {
        class Program
        {
            static void Change(int input)
            {
                input = 20;
            }

            static void Main302(string[] args)
            {
                int a = 10;
                Change(a);
                Console.WriteLine(a);
            }

            // 1. 변수 a에 10을 넣었고 Change() 메서드를 호출함 이때 10 이라는 값이 복사된다
        }
    }
}
