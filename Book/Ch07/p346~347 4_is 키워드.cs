using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p346
    {
        // is 키워드 : 특정한 클래스가 어떤 클래스인지 확인하기 위해 사용
        static void Main346(string[] args)
        {
            //List<Animal> Animals = new List<Animal>() { /* 생략 */}

            //foreach(var item in Animals)
            //{
            //    item.Eat();
            //    item.Sleep();

            //    if (item is Dog) { }  // 만약 변수 item이 Dog 클래스라면
            //    if (item is Cat) { }  // 만약 변수 item이 Cat 클래스라면
            //}

            // 변수 item이 Dog 클래스라면 다음과 같은 경우 모두 treu를 출력
            // item is Dog
            // item is Animal
            // item is Object
        }
    }
}
