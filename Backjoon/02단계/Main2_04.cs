using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _Main2_04
    {
        static void Main4(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (a > 0 && b > 0)
            {
                Console.WriteLine("1");
            }

            else if (a < 0 && b > 0)
            {
                Console.WriteLine("2");
            }

            else if (b < 0 && a < 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }
        }
    }
}
