using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class _Main2_02
    {
        static void Main2(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            
            
            if(90 <= score) {
                Console.WriteLine("A");
            }else if(80 <= score) {
                Console.WriteLine("B");
            }
            else if (70 <= score) {
                Console.WriteLine("C");
            }
            else if (60 <= score) {
                Console.WriteLine("D");
            } else {
                Console.WriteLine("F");
            }

            Console.WriteLine();
        }
    }
}
