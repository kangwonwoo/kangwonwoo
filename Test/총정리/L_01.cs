using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/27
 * 이름 : 강원우
 * 내용 : [총정리 문제] 입출력
 */
namespace Test.총정리
{
    internal class L_01
    {
        static void Main1(string[] args)
        {
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();

            Console.Write("나이 입력 : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("키 입력(cm) : ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요. ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.Write(height);
            Console.Write("cm 입니다. ");
        }
    }
}
