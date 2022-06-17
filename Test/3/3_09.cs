using System;
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
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형 그리기...");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원 그리기...");
        }
    }

    internal class _3_09
    {
        static void Main9(string[] args)
        {
            _3_09 instance = new _3_09();

            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            instance.Draw(circle);   // instance는 abstract 의  추상적 개념을 실체화 시킨다.
            instance.Draw(triangle);
        }

        public void Draw(Shape shape)  // 원과 삼각형 모두 포함 시켜야 함으로 Shape 사용
        {
            shape.Draw();
        }
    }
}
