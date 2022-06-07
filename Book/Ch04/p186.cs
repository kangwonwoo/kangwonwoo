using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p186
    {
        static void Main186(string[] args)
        {
            // Console.Clear()             : 콘솔 화면을 지웁니다.
            // Console.SetCursorPosition() : 콘솔 화면의 특정한 위치로 커서를 옮깁니다.
            // Console.Sleep()             : 특정한 시간만큼 스레드를 정지합니다.

            Console.WriteLine("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("메서드 호출 후");
        }
    }
}
