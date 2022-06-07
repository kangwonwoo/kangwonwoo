using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p184
    {
        static void Main184(string[] args)
        {
            // 공백 제거 메서드
            // Trim()      : 문자열 양 옆의 공백을 제거합니다.
            // TrimStart() : 문자열 앞의 공백을 제거합니다.
            // TrimEnd()   : 문자열 뒤의 공백을 제거합니다.

            string input = " test      \n";
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }
       
    }
}
