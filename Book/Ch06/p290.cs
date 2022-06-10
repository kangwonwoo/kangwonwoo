using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p290
    {
        // 상수 변경
        static void Main290(string[] args)
        {
            // 상수는 변경할 수 있는 대상이 아님 
            //Math.PI = 20;
            

            int r = 10;
            Console.WriteLine("원의 둘레 : "+ (2 * Math.PI * r));
            Console.WriteLine("원의 넓이 : "+ (Math.PI * r * r));
        }
    }
}
