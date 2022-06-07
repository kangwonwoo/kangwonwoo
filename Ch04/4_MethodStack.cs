using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/07
 * 이름 : 강원우
 * 내용 : 
 */
namespace Ch04
{
    internal class MethodStack
    {
        static void Main4(string[] args)
        {
            int result = 0;
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);

            Console.WriteLine("result : "+result);
        }

        public static int Sum(int start, int end)
        {
            int total = 0;

            for (int k = start; k <= end; k++)
            {
                total += k;
            }
            return total;   // 스택이 쌓이다가 마지막에는 하나씩 스택 제거
        }
    }
}
