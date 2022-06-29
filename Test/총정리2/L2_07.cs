using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 강원우
 * 내용 : [총정리 문제] 피라미드 메서드
 */
namespace Test.총정리2
{
    internal class L2_07
    {
        static void Main7(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        public static void DrawPyramid(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = i; j < n; j++)
                    Console.Write(" ");

                for (int k = 1; k < 2 * i; k++)
                    Console.Write(" ");

                Console.WriteLine();
            }
        }
    }
}
