using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p281
    {
        // 내부 클래스에서의 접근 -> 외부에서는 접근 불가
        class Program
        {
            class Test
            {
                public void TestMethod()
                {
                    Program.Main281(new string[] { "" });  // 내부 클래스의메ㅓ드에서 private 메서드 접근
                }
            }

            public void TestMethod()
            {
                Program.Main281(new string[] { "" });  // 자신의 클래스가 가진 메서드에서 private 메서드 접근
            }

            static void Main281(string[] args)
            {

            }
        }
    }
}
