using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p284
    {
        // 기본 생성자 식
        class Product
        {
            public string Name;
            public int price;

            public Product(string name, int price)
            {
                this.Name = name;
                this.price = price;
            }   
        }

        // 인스턴스 생성 개수 확인
        class Program
        {
            class Product
            {
                public static int counter = 0;
                public int id;
                public string name;
                public int price;

                public Product(string name, int price)
                {
                    Product.counter = counter + 1;
                    this.id = counter;
                    this.name = name;
                    this.price = price;
                }
            }

            static void Main284(string[] args)
            {
                Product productA = new Product("감자", 2000);
                Product productB = new Product("고구마", 3000);

                Console.WriteLine(productA.id + ":" + productA.name);
                Console.WriteLine(productB.id + ":" + productB.name);
                Console.WriteLine(Product.counter + "개 생성되었습니다.");
            }
        }
    }
}
