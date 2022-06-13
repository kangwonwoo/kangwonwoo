using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p362
    {
        // new 메서드를 사용한 하이딩 -> 하이딩은 '같은 이름으로 멤버를 만들어 부모의 멤버를 숨긴다'
        class Program
        {
            class Parent
            {
                public int variable = 273;
                public void Method()
                {
                    Console.WriteLine("부모의 메서드");
                }
            }

            class Child : Parent
            {
                public new string variable = "hiding";
                public new void Method()
                {
                    Console.WriteLine("자식의 메서드");
                }
            }

            static void Main362(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }
    }
}
