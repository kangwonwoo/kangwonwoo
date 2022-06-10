using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p306
    {
        // 재귀 메서드 : 어떠한 메서드 내부에서 자기 자신을 호출하게 되는 메서드
        class Program
        {
            static void Main306(string[] args)
            {
                Main306(new string[0]);  // 자기 자신을 호출함
            }
        }
    }
}
