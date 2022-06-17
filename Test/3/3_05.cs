﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/16
 * 이름 : 강원우 
 * 내용 : 싱글톤 객체 연습문제
 */
namespace Test._3
{
        class Vehicle
        {
            private string name;
            private int price;
            
            public Vehicle(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

            public void Show()
            {
                Console.WriteLine("==================");
                Console.WriteLine("차량명 : " + name);
                Console.WriteLine("가격 : " + price);
                Console.WriteLine("-------------------");
            }
        }

        class CarFactory
        {
            private static CarFactory instance = new CarFactory();
            private CarFactory() { }  // private으로 인해 new 를 사용 못함

            public static CarFactory Instance
            {
                get { return instance; }
            }

            public Vehicle MakeCar(string name, int price)
            {
               return new Vehicle(name, price);
            }
        }

        internal class _3_05
        {
            static void Main5(string[] args)
            {
                CarFactory factory = CarFactory.Instance;

                Vehicle avante = factory.MakeCar("아반테", 2500);
                Vehicle sonata = factory.MakeCar("소나타", 3000);

                avante.Show();
                sonata.Show();
            }
        }
    
}
