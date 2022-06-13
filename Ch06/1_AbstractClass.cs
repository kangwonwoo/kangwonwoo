using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13  
 * 이름 : 강원우
 * 내용 : 추상 클래스 실습하기 교재 p230
 */
namespace Ch06
{
    internal class _1_AbstractClass
    {
        static void Main(string[] args)
        {
            // 추상클래스는 객체 생성 X
            // Car car = new Car();

            Car sedan = new Sedan("그랜저", "검정색", 0, 2000);
            Car truck = new Truck("포터", "파란색", 0, 1);

            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            truck.SpeedUp(80);
            truck.SpeedDown(10);
            truck.Show();

        }
    }
}
