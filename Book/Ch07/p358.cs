using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p358
    {
        // 하이딩
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
            }
        }
    }
}
