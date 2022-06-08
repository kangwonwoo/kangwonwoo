using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p226
    {
        class product
        {
            public string name;
            public int price;
        }

        static void Main226(string[] args)
        {
            product p = new product();

            p.name = "스마트폰";
            p.price = 100000;

            Console.WriteLine(p.name + " : " + p.price + "원");
        }
    }
}
