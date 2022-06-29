using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 강원우
 * 내용 : [총정리 문제] 재귀 메서드
 */
namespace Test.총정리2
{
    internal class L2_05
    {
        static void Main5(string[] args)
        {
            int a = 10;
            int b = 30;
            int c = 20;

            Console.WriteLine("가장 큰 수는 {0} 입니다.", Larger(Larger(a, b), c));
        }

        public static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
