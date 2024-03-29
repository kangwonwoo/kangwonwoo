﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch09
{
    internal class p426
    {
        // 기본 클래스와 자료 생성
        class Program
        {
            class Product
            {
                public string Name { get; set; }
                public int Price { get; set; }

                public override string ToString()
                {
                    return Name +" : " + Price +"원";
                }
            }

            static void Main426(string[] args)
            {
                List<Product> list = new List<Product>()
                {
                    new Product(){Name = "고구마", Price = 1500},
                    new Product(){Name = "사과", Price = 2400},
                    new Product(){Name = "바나나", Price = 1000},
                    new Product(){Name = "배", Price = 3000}
                };
                list.Sort();

                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
