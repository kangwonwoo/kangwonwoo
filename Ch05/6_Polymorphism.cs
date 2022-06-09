using Ch05.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 아름 : 강원우
 * 내용 : 다형성 실습하기 교재 p340
 */
namespace Ch05
{
    internal class _6_Polymorphism
    {
        static void Main(string[] args)
        {
            // 다형성을 적용한 객체 생성
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark();

            a1.Move();
            a2.Move();
            a3.Move();

            // 객체 타입 캐스팅
            Tiger tiger = (Tiger) a1;
            Eagle eagle = (Eagle) a2;  // = (Eagle eagle = a2 as Eagle)
            Shark shark = (Shark) a3;

            tiger.Hunt();
            eagle.Hunt();
            shark.Hunt();

            // 객체 타입 확인
            if(a1 is Tiger)
            {
                Console.WriteLine("a1은 Tiger입니다.");
            }

            if(a2  is Eagle)
            {
                Console.WriteLine("a2는 Eagle입니다.");
            }

            if(a3 is Shark)
            {
                Console.WriteLine("a3는 Shark입니다.");
            }
        }
    }
}
