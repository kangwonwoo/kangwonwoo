using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p398
    {
        // 인덱서 선언
        class Products
        {
            public int this[int i]
            {
                // Priducts products = new Product();
                // products[i] 할 때 호출
                get { return i; }
                // Products[i] = 10 할 때 호출
                set { Console.WriteLine(i + "번째 상품 결정"); }
            }
        }
    }
}
