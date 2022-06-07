using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p183
    {
        static void Main183(string[] args)
        {
            // Split() : 문자열을 특정한 문자 또는 문자열로 자릅니다.

            string input   = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
