using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p282
    {
        // public  접근 제한자를 붙인 Main() 메서드
        
        class Test
        {
            public void TestMethod()
            {
                Program.Main282(new string[] { "" });
            }
        }
        class Program
        {
            public static void Main282(string[] arga)  // public을 접근 제한자로 추가
            {

            }
        }
    }
}
