using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Backjoon._01단계
//{
//    internal class Main1_06
//    {
//        static void Main6(string[] args)
//        {
//            string[] num = Console.ReadLine().Split();

//            double n1 = double.Parse(num[0]);
//            double n2 = double.Parse(num[1]);

//            Console.WriteLine(n1 / n2);
//        }
//    }
//}

namespace baekjoon
{
    class 사칙연산
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split();

            Console.WriteLine(double.Parse(s[0]) / double.Parse(s[1]));
        }
    }
}
