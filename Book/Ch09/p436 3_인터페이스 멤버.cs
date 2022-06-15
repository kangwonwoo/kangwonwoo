using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p436_3_인터페이스_멤버
    {
        interface IBasic
        {
            int TestInstanceMethod();
            int TestProperty { get; set; }
        }

        class Program
        {
            //class TestClass : IBasic  --> IBasic을 (ctrl + .)으로 인터페이스 구현 해줘야함
            //{

            //}

            static void Main436(string[] args)
            {

            }
        }
    }
}
