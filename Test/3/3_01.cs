using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 강원우 
 * 내용 : 클래스 연습문제
 */
namespace Test._3
{
    internal class _3_01
    {
        private string name;
        private int age;

        public _3_01(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("이름 : "+ this.name);
            Console.WriteLine("나이 : "+ this.age);
            Console.WriteLine("-------------------");
        }

        static void Main1(string[] args)
        {
            Name kim = new Name("김유신", 23);
            Name lee = new Name("이순신", 31);

            kim.Show();
            lee.Show();
        }
    }
}
