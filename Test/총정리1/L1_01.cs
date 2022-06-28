using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/28
 * 이름 : 강원우
 * 내용 : [총정리 문제] 윤년 판별하기
 * 
 * 윤년
 * - 2월29일이 추가 되어 1년이 366일인 해
 * - 4로 나누어지고 100우로 나누어지지 않거나 400으로 나누어지는 연도
 */
namespace Test.총정리1
{
    internal class L1_02
    {
        static void Main1(string[] args)
        {
            Console.Write("연도 입력 : ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0}는 윤년 입니다.", year);
            }
            else 
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}는 윤년 입니다.", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }
        }
    }
}
