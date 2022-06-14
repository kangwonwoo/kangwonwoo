using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p399
    {
        // 인덱서로 배열처럼 사용하는 제곱 클래스
        class SquareCalculator
        {
            public int this[int i]
            {
                get
                {
                    return i * i;
                }
            }
        }

        class Program
        {
            static void Main399(string[] args)
            {
                SquareCalculator square = new SquareCalculator();
                Console.WriteLine(square[20]);
            }
        }
    }
}
