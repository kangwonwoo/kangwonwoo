using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            if(X > 0 && Y > 0)
            {
                Console.WriteLine("1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("3");
            }
            else if(X > 0 && Y < 0)
            {
                Console.WriteLine("4");
            }
        }
    }
}
