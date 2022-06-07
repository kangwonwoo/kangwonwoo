using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Threading;

namespace Book.Ch04
{
    internal class p187
    {
        static void Main187(string[] args)
        {
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");

            int x = 1;
            while (x < 50)
            {
                // 화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                // 출력합니다
                if (x % 3 == 0)
                    Console.WriteLine(" __@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                // 100밀리초 정지하고 x를 증가합니다.
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
