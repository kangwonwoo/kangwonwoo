using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p440
    {
        class program
        {
            class Parent { }

            class Child : Parent, IDisposable, IComparable  // 한 개의 클래스와 두 개의 인터페이스를 상속받는다.
            {
                public void Dispose()
                {
                    throw new NotImplementedException();
                }

                public int CompareTo(object? obj)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
