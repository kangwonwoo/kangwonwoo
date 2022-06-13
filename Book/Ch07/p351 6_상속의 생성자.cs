using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p351
    {
        // 상속의 생성자
        // - 생성자 : 인스턴스를 초기화할 때 사용합니다.
        // - 자식 인스턴스를 생성하면, 부모가 가지고 있는 멤버 초기화를 위해 부모 생성자도 자동으로 호출된다. 
        class Program
        {
            class Parent
            {
                public Parent()
                {
                    Console.WriteLine("부모 생성자");
                }
            }

            class Child : Parent
            {
                public Child()
                {
                    Console.WriteLine("자식 생성자");
                }
            }

            static void Main351(string[] args)
            {
                Child child = new Child();
            }
        }
    }
}
