using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p443
    {
        static void Main443(string[] args)
        {
            //  @ 기호를 사용한 문자열(Verbatim String : 축자 문자열)
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다");

            //  파일 읽기
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
        }
    }
}
