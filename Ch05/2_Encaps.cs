using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 강원우
 * 내용 : 캡슐화 실습하기 교재 p203
 */
namespace Ch05
{
    internal class _2_Encaps
    {
        static void Main(string[] args)
        {
            // 1. Sub2 private 하기 전
            //Account kb = new Account();
            //kb.bank = "국민은행";
            //kb.id = "110-11-1234";
            //kb.name = "김유신";
            //kb.balance = 1000;

            //kb.Deposit(4000);
            //kb.Withdraw(3000);

            //kb.balance--;
            //kb.balance += 10;

            //kb.Show();



            // 2. Sub2 private 한 후
            // 객체 생성과 초기화(생성자 호출)
            Account kb = new Account("국민은행", "110-11-1234", "김유신", 1000);
            
            // 1번 참조 변수 생성
            // 2번 heap 객체 생성(Account)
            // 3번 객체 생성
            // 4번 주소값 대입

            //기능
            kb.Deposit(4000);
            kb.Withdraw(3000);

            // 캡슐화로 취약코드 해방
            // kb.balance--;
            // kb.balance += 10;

            kb.Show();

            // Car 객체 생성과 초기화
            Car sonata = new Car("소나타", "흰색", 0);
            Car bmw = new Car("BMW", "검정색", 0);
            Car benz = new Car("벤츠", "흰색", 0);

            // setter 실행
            sonata.Name = "EF소나타";
            sonata.Speed = -100;

            // getter 실행
            Console.WriteLine("sonata 객체 name : "+sonata.Name);

            sonata.SpeedUp(60);
            sonata.Show();

            bmw.SpeedUp(50);
            bmw.Show();

            benz.SpeedUp(30);
            benz.Show();
        }
    }
}
