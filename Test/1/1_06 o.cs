using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 강원우
 * 내용 : 조건문 연습문제
 */
namespace Test._1
{
    internal class _1_06
    {
        static void Main6(string[] args)
        {
            Console.Write("점수 입력 : ");
            int score = int.Parse(Console.ReadLine());
            char grade;

            Console.Write("입력한 점수는 {0}점 이고, 등급은 ", score);

            if(90 <= score) {
                grade = 'A';
            }else if(80 <= score && score < 90) {
                grade = 'B';
            }
            else if (70 <= score && score < 80) {
                grade = 'C';
            }
            else if (60 <= score && score < 70) {
                grade = 'D';
            } else {
                grade = 'F';
            }

            Console.WriteLine(grade+"입니다");  // = ("입니다",grade)
        }
    }
}
