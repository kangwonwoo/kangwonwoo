using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p370
    {
        // sealed 메서드 오류
        class Program
        {
            class Parent
            {
                public virtual void Test() { }
            }

            class Child : Parent
            {
                sealed public override void Test() { }
            }

            class GrandChild : Child
            {
                //public override void Test() { }  -> 오류 발생
            }
        }
    }
}
