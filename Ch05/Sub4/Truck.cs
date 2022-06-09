﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Truck : Car
    {
        private int capacity;
        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차량명 : " + name);
            Console.WriteLine("차량색 : " + color);
            Console.WriteLine("차량속도 : " + speed);
            Console.WriteLine("차량배기량 : " + capacity);
            Console.WriteLine("----------------");
        }
    }
}
