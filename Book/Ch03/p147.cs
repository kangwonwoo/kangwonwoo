﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p147
    {
        static void Main147(string[] args)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로 이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼로 이동");
                    break;
                default:
                    Console.WriteLine("다른 키를 눌렀습니다");
                    break;
            }
        }
    }
}
