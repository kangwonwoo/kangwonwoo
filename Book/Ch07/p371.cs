using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p371
    {
        // abstract 키워드 : sealed와 반대로 무조건 상속해서 쓰라는 의미 or 이 메서드는 반드시 오버라이딩 해라

        // abstract 클래스 오류
         class Program
        {
            abstract class Parent
            {
                public void Test() { }
            }

            class Child : Parent
            {
                public void Test() { }
            }

            static void Main371(string[] args)
            {
                // Parent parent = new Parent();  --> 오류 발생
                Child child = new Child();

                // parent.Test();
                child.Test();
            }
        }
    }
}
