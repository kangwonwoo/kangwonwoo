using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 강원우
 * 내용 : [총정리 문제] 반복문 x의 y승 구하기
 */
namespace Test.총정리1
{
    internal class L1_04
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("x의 y승을 계산");

            Console.Write("x입력 : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y입력 : ");
            int y = int.Parse(Console.ReadLine());

            int pow = 1;
            for (int i=0; i < y; i++)
            {
                pow *= x;
            }

            Console.WriteLine("{0}의 {1}승은 {2} 갑니다");
        }
    }
}
