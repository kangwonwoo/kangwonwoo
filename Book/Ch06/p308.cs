using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p308
    {
        // 재귀 메서드를 이용한 피보나치 클래스 메서드
        class Fibonacci
        {
            public static long Get(int i)
            {
                if (i < 0) { return 0; }
                if (i == 1) { return 1; }
                if (i == 2) { return 1; }
                return Get(i - 2) + Get(i - 1);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Fibonacci fibo = new Fibonacci();
                Console.WriteLine(Fibonacci.Get(1));
                Console.WriteLine(Fibonacci.Get(2));
                Console.WriteLine(Fibonacci.Get(3));
                Console.WriteLine(Fibonacci.Get(4));
                Console.WriteLine(Fibonacci.Get(5));
            }
        }
    }
}
