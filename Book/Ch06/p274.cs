using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p274
    {
        // 클래스 메서드에서 발생할 수 있는 오류
        class Program
        {
            public static int instanceVariable = 10;   // static이 빠지면 오류 발생

            static void Main274(string[] args)
            {
                Console.WriteLine(instanceVariable);
            }
        }
    }
}
