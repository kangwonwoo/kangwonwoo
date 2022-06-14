using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch08
{
    internal class p397
    {
        // 제네릭 : 클래스 내부에서 자료형에 별칭을 지정하는 기능
        // - 여러개의 말도 지정 가능
        class Wanted<T, U>
        {

        }

        // Where 키워드
        class Wanted1<T, U>
            where T : class
            where U : struct
        {

        }
    }
}
