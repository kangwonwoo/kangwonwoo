using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p348
    {
        // 일반적인 자료형 변환 : (클래스) 변수

        static void Main348(string[] args)
        {
            //List<Animal> Animals = new List<Animal>() { /* 생략 */}

            //foreach(var item in Animals)
            //{
            //    item.Eat();
            //    item.Sleep();

            //    if (item is Dog) { ((Dog)item).Bark(); }  
            //    if (item is Cat) { ((Cat)item).Meow(); }  
            //}

            // 변수 item이 Dog 클래스라면 다음과 같은 경우 모두 treu를 출력
            // item is Dog
            // item is Animal
            // item is Object
        }

    }
}
