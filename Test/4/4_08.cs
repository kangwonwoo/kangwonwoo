using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/17
 * 이름 : 강원우
 * 내용 : 객체 형변환 연습문제
 */
namespace Test._4
{
    class Apple // : object를 상속 받고 있다고 기본적으로 생각
    {
        public void Show()
        {
            Console.WriteLine("사과 입니다.");
        }
    }
    class Banana
    {
        public void Show()
        {
            Console.WriteLine("바나나 입니다.");
        }
    }
    class Grape
    {
        public void Show()
        {
            Console.WriteLine("포도 입니다.");
        }
    }

    internal class _4_08
    {
        static void Main8(string[] args)
        {
            Apple apple = new Apple();
            Banana banana = new Banana();
            Grape grape = new Grape();

            Show(apple);
            Show(banana);
            Show(grape);
        }

        public static void Show(object fruit)
        {
            if(fruit is Apple)
            {
                Apple apple = (Apple) fruit; // = fruit as Apple
                apple.Show();
            }
            else if (fruit is Banana)
            {
                Banana banana = fruit as Banana;
                banana.Show();
            }
            else if (fruit is Grape)
            {
                Grape grape = fruit as Grape;
                grape.Show();
            }
        }
    }
}
