using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p369
    {
        // sealed 클래스 오류
        class Program
        {
            sealed class Parent
            {
                public void Test() { }
            }

            class Child
            {
                public void Test() { }
            }

            static void Main(string[] args)
            {
                Parent parent = new Parent();
                Child child = new Child();

                parent.Test();
                child.Test();
            }
        }
    }
}
