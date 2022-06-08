using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p209
    {
        static void Main209(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            // ()NextDouble 메서드는 0.0과 1.0 사이의 난수(임의의 수)를 반환한다.
        }
    }
}
