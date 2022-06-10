using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p292
    {
        // readonly 키워드 : 읽기 전용 변수는 클래스 변수 or 변수 앞에 readonly키워드를 붙인다.
        class Product
        {
            private static int count;
            public readonly int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                id = count++;
                this.name = name;
                this.price = price;
            }
        }

        // readonly 키워드를 붙인  클래스 변수는 변수를 선언하는 시점과
        // 생성자 메서드에서만 값을 변경할 수 있다.
    }
}
