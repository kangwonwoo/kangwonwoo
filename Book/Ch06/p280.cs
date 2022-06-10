using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p280
    {
        // 외부 클래스에서의 접근
        class Test
        {
            public void TestMethod()
            {
                //Program.Main(new string[] { "" });    --> 'Main'이 private에 의해 접근 불가 상태
            }
        }

        class Program
        {
            static void Main280(string[] args)
            {

            }
        }
    }
}
