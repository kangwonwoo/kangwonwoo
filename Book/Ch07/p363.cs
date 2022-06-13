using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p363
    {
        // virtual과 override 메서드
        // 오버라이딩은 '부모의 메서드를 덮어씌운다'는 개념이다.
        class Program
        {
            class Parent
            {
                public virtual void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public override void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main363(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }
    }
}
