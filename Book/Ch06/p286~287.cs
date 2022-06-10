using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p286
    {
        // 정적 생성자 : 정적 요소를 초기화할 때에 사용되는 생성자.
        // 생성자 앞에 static 키워드를 붙여 생성
        class Sample
        {
            public static int value;

            static Sample()
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }

        // 정적 생성자를 만들 때는 다음과 같이 제한이 생김
        // - 접근 제한자 사용 X
        // - 매개변수 사용 X

        // 정적 생성자의 호출 시점
        static void Main286(string[] args)
        {
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");


            Console.WriteLine("첫 번째 위치");
            Sample sample1 = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");
        }
    }
}
