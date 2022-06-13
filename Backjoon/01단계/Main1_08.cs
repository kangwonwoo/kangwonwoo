using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._01단계
{
    internal class Main1_08
    {
        static void Main8(string[] args)
        {
            string[] num = Console.ReadLine().Split();

            float n1 = float.Parse(num[0]);
            float n2 = float.Parse(num[1]);

            Console.WriteLine(n1 / n2);
        }
    }
}
