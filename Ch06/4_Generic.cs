using Ch06.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/14
 * 이름 : 강원우
 * 내용 : 제네릭 실습하기 교재 p395
 */
namespace Ch06
{
    
    class FruitBox <T>
    {
        private T fruit;

        // Getter, Setter
        public T Fruit
        {
            get { return fruit; }
            set { fruit = value; }
        }
    }

    internal class _4_Generic
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("한국", 3000);
            Banana banana = new Banana("대만", 4000);

            FruitBox<Apple> box1 = new FruitBox<Apple>();
            box1.Fruit = apple;  // Setter 호출
            box1.Fruit.show();   // Getter 호출

            FruitBox<Banana> box2 = new FruitBox<Banana>();
            box2.Fruit = banana;
            box2.Fruit.show();
        }
    }
}
