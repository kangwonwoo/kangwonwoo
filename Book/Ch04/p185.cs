using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p185
    {
        static void Main185(string[] args)
        {
            // string.Join() : 배열의 요소를 뭉쳐 문자열로 변경합니다.

            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",",array));
        }
    }
}
