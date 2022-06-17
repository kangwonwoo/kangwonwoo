﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 강원우 
 * 내용 : 다형성 연습문제
 */
namespace Test._3
{
    class Product
    {
        protected string category;
        protected int price;

        public Product(string category, int price)
        {
            this.category = category;
            this.price = price;
        }
        public virtual void Show() { }
    }

    class Television : Product
    {
        public Television(String category, int price) : base(category, price)
        {
        }

        public override void Show()
        {
            Console.WriteLine("제품분류 : "+category);
            Console.WriteLine("제품가격 : "+price);
        }
    }

    class Computer : Product
    {
        public Computer(string category, int price) : base(category, price)
        {
        }

        public override void Show()
        {
            Console.WriteLine("제품분류 : " + category);
            Console.WriteLine("제품가격 : " + price);
        }
    }

    internal class _3_08
    {
        static void Main8(string[] args)
        {
            Product p1 = new Television("TV", 100);
            Product p2 = new Computer("컴퓨터", 150);

            p1.Show();
            p2.Show();
        }
    }
}
