using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        // 속성(필드)
        protected string name;  // private에서 protected를 사용해줌으로써 상속 기능만은 사용 가능하다. 아직 외부에서는 사용불가
        protected string color;
        protected int speed;  //  (this.speed)

        // 생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        // 기능(메서드)
        public void SpeedUp(int speed)  //  (speed2)
        {
            this.speed += speed;
        //               (speed2)   
        }
        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }
        public void Show()
        {
            Console.WriteLine("==================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
        }
    }
}
