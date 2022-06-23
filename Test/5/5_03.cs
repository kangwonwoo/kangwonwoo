﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/23
 * 이름 : 강원우
 * 내용 : 리스트 연습문제
 */
namespace Test._5
{
    internal class _5_03
    {
        static void Main3(string[] args)
        {
            printList(createList());
        }

        public static void printList(List<int> scoreList)
        {
            int total = 0;
            int count = scoreList.Count;

            for(int i = 0; i < count; i++)
            {
                int score = scoreList[i];

                    total += score;

                Console.Write(score);

                if(i == count - 1)
                    Console.Write(" = ");
                else
                    Console.Write(" + ");
            }
            Console.WriteLine(total);
        }

        public static List<int>  createList()
        {
            List<int> scoreList = new List<int>();
            Random rand = new Random();

            for(int i = 1; i <= 10; i++)
            {
                //  60 ~ 100사이 임의의 수
                int nunm = rand.Next(41) + 60;
                scoreList.Add(nunm);
            }

            return scoreList;
        }
    }
}
