using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p401
    {
        // in.TryParse() 메서드
        class Program
        {
            static void Main401(string[] args)
            {
                Console.Write("숫자 입력 : ");
                int output;
                bool result = int.TryParse(Console.ReadLine(), out output);  // out 키워드를 붙여서 매개변수를 넣어줘야 함

                if(result)
                {
                    Console.WriteLine("입력한 숫자 : "+output);
                }
                else
                {
                    Console.WriteLine("숫자를 입력해주세요!");
                }
            }
        }
    }
}
