using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p438
    {
        interface IBasic
        {
            int TestInstanceMethod();
            int TestProperty { get; set; }
        }

        class TestClass : IBasic
        {
            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }

            public int TestProperty
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }
        }

        // 위와 같이 인터페이스를 구현해 줌으로써 밑에 있는 인터페이스 다형성이 가능해 진다.
        static void Main438(string[] args)
        {
            IBasic basic = new TestClass();
        }
    }
}
