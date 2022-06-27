using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/27
 * 이름 : 강원우
 * 내용 : [총정리 문제] ref
 * 
 * ref
 * - ref 키워드는 메서드의 매개변수의 인자값이 참조로 전달할 떄 사용
 * - ref에 의한 값 전달은 매개변수가 메서드에 넘겨진 원본 변수를 직접 참조
 */
namespace Test.총정리
{
    internal class L_10
    {
        static void Main10(string[] args)
        {
            string s = "before";
            Console.WriteLine(s);

            Test(s);
            Console.WriteLine(s);

            Test(ref s);
            Console.WriteLine(s);
        }

        public static void Test(string s)
        {
            s = "after";
        }

        public static void Test(ref string s2)
        {
            s2 = "after";
        }
    }
}
