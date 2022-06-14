using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p373
    {
        class Program
        {
            abstract class Parent
            {
                // public abstract void Test() { } 
            }

            class Child : Parent
            {
                // public override void Test() { }   // override를 사용해서 오류 해결
            }

            static void Main373(string[] args)
            {
                // Parent parent = new Parent();  --> 오류 발생
                Child child = new Child();

                //parent.Test();
                //child.Test();
            }
        }
    }
}
