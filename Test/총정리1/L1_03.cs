using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 강원우
 * 내용 : [총정리 문제] 반복문으로 2진, 8진 ,16진수 출력
 */
namespace Test.총정리1
{
    internal class L1_03
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("{0,5}{1,8}{2,3}{3,4}", "십진수", "2진수2", "8진수", "16진수");

            for(int i = 1; i <= 128; i++)
            {
                Console.WriteLine("{ 0,7}{1,10}{2,5}{3,6}", i,
                     Convert.ToString(i, 2).PadLeft(8, '0'),
                     Convert.ToString(i, 8),
                     Convert.ToString(i, 16));
            }
        }
    }
}
