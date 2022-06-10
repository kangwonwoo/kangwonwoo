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
            char grade;
            
            if(90 <= score) {
                grade = 'A';
            }else if(80 <= score && score <= 89) {
                grade = 'B';
            }
            else if (70 <= score && score <= 79) {
                grade = 'C';
            }
            else if (60 <= score && score <= 69) {
                grade = 'D';
            } else {
                grade = 'F';
            }

            Console.WriteLine(grade);
        }
    }
}
