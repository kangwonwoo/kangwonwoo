using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p359
    {
        // 숨겨진 멤버를 찾는 방법
        class Program
        {
            class Parent
            {
                public int variable = 273;
            }

            class Child : Parent
            {
                public string variable = "shadowing";
            }

            static void Main358(string[] args)
            {
                Child child = new Child();
                Console.WriteLine(child.variable);

                Child child1 = new Child();
                Console.WriteLine(((Parent)child).variable);
            }
        }

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

            static void Main(string[] args)
            {
                Child child = new Child();
                child.Method();
                ((Parent)child).Method();
            }
        }
    }
}
