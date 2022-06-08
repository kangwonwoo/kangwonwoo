using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 강원우
 * 내용 : 클래스와 객체 실습하기 교재 p203
 */
namespace Ch05
{
    internal class _1_Class
    {
        static void Main(string[] args)
        {
            // 객체 생성  // --> (Car를 참조연산자(ctrl + .) 키로 출처 사용)
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            // 객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            // 예) 객체 생성(bmw, 검정색)
            Car bmw = new Car();

            bmw.name = "bmw";
            bmw.color = "검정색";
            bmw.speed = 0;

            bmw.SpeedUp(10);
            bmw.SpeedUp(90);
            bmw.SpeedDown(30);
            bmw.Show();

            // Account 객체 생성
            Account kb = new Account();
            kb.bank = "국민은행";
            kb.id = "101-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            // 기능
            kb.Deposit(25000);
            kb.Withdraw(5000);
            kb.Show();

            // 예) nh 객체 생성
            Account nh = new Account();
            nh.bank = "농협";
            nh.id = "120-11-1424";
            nh.name = "김춘추";
            nh.balance = 30000;

            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();
        }
    }
}
