using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p432
    {
        // Dispose() 메서드 구현 및 호출하기
        class Program
        {
            class Dummy : IDisposable
            {
                public void Dispose()
                {
                    Console.WriteLine("Disposw() 메서드를 호출합니다.");
                }
            }

            static void Main432(string[] args)
            {
                Dummy dummy = new Dummy();
                dummy.Dispose();

                // using 키워드와 IDisposable 인터페이스
                using(Dummy dummy2 = new Dummy())
                {

                }
            }
        }
    }
}
