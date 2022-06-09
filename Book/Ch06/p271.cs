using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p271
    {
        class Program
        {
            class Test
            {
                public int Multiply(int min, int max)
                {
                    int output = 1;
                    for(int i = min; i <= max; i++)
                    {
                        output *= i;
                    }
                    return output;
                }
            }


            static void Main271(string[] args)
            {
                Test test = new Test();
                Console.WriteLine(test.Multiply(1, 10));
            }
        }
    }
}
