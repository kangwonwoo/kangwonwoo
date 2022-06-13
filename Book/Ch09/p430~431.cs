using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p430
    {
        // IDisposable 인터페이스 상속 및 메서드 생성
        class Program
        {
            class Dummy : IDisposable
            {
                public void Dispose()
                {
                    throw new NotImplementedException();
                }
            }

            static void Main430(string[] args)
            {

            }
        }
    }
}
