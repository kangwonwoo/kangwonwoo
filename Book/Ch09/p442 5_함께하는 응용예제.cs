using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p442
    {
        // 파일에 문자열 쓰기
        static void Main442(string[] args)
        {
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다");
        }
    }
}
