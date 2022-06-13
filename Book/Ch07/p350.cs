using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch07
{
    internal class p350
    {
        static void Main350(string[] args)
        {
            //List<Animal> Animals = new List<Animal>() { /* 생략 */}

            //foreach(var item in Animals)
            //{
            //    item.Eat();
            //    item.Sleep();

            //    if (item is Dog) { (item as Dog).Bark(); }  
            //    if (item is Cat) { (item as Cat).Meow(); }  
            //}


            // as 키워드를 사용하는 경우의 일반적인 형태
            //foreach(var item in Animals)
            //{
            //    item.Eat();
            //    item.Sleep();

            //    var dog = item as Dog;
            //    if (dog != null) {dog.Bark();}

            //    var cat = item as Cat;
            //    if (cat != null) {cat.Meow();}
            //}

            // 변수 item이 Dog 클래스라면 다음과 같은 경우 모두 treu를 출력
            // item is Dog
            // item is Animal
            // item is Object
        }
    }
}
