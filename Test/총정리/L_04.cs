using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/27
 * 이름 : 강원우
 * 내용 : [총정리 문제] 문자열과 숫자의 변환
 */
namespace Test.총정리
{
    internal class L_04
    {
        static void Main4(string[] args)
        {
            string input;
            int value;

            Console.Write("1) int로 변환할 문자열 입력 : ");
            input = Console.ReadLine();

            bool result = Int32.TryParse(input, out value);

            if(!result)
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
            else
                Console.WriteLine("int '{0}'으로 변환 했습니다.\n", value);

            Console.Write("2) double로 변환할 문자열 입력 : ");
            input = Console.ReadLine();

            try
            {
                double m = double.Parse(input);
                Console.WriteLine("double '{0}'으로 변환 했습니다.\n", m);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
