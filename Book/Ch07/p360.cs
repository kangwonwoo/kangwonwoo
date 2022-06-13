using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p360
    {
        // 메서드 하이딩
        class Program1
        {
            class Parent
            {
                public void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main359(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }

        // 'Child.Method()은 상속된 Parent.Method() 멤버를 숨깁니다. 숨기려면 new 키워드를 사용하십시오.' 라고 되어있다.
        // - 이 말은 Method() 메서드가 하이딩 되었다는 말이다.
        // - 메서드는 변수와 다르게 출동이 발생할 때 하이딩할지 오버라이딩할지를 결정할 수 있다.
    }
}
