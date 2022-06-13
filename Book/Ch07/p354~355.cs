using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p354
    {
        // 클래스 변수 상속
        class Program
        {
            class Parent
            {
                public static int counter = 0;

                public void CountParent()
                {
                    Parent.counter++;
                }
            }

            class Child : Parent
            {
                public void CountChild()
                {
                    Child.counter++;
                }
            }

            static void Main354(string[] args)
            {
                Parent parent = new Parent();
                Child child = new Child();

                parent.CountParent();
                child.CountChild();

                Console.WriteLine(Parent.counter);
                Console.WriteLine(Child.counter);
            }
        }
    }
}
