using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p437
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
    }
}
