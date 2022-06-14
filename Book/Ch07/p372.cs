using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p372
    {
        // abstract 메서드
        class Program
        {
            abstract class Parent
            {
                //public abstract void Test() { }   -> 오류
            }

            class Child : Parent
            {
                public void Test() { }  // 오류 
            }

            static void Main372(string[] args)
            {
                // Parent parent = new Parent();  --> 오류 발생
                Child child = new Child();

                // parent.Test();
                child.Test();
            }
        }
    }
}
