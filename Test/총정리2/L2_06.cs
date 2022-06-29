using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/29
 * 이름 : 강원우
 * 내용 : [총정리 문제]
 */
namespace Test.총정리2
{
    internal class L2_06
    {
        static void Main6(string[] args)
        {
            int count = 0;

            for(int i =  2; i <= 100; i++)
            {
                if(IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine("\n2~100까지 소수는 모두 {0}개 입니다.", count);
        }

        public static bool IsPrime(int x)
        {
            for(int i = 2; i < x; i++)
            {
                if(x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
