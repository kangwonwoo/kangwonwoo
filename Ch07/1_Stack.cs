using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15 
 * 이름 : 강원우
 * 내용 : 컬렌션 스택 실습
 * 
 *  Stack : 순서대로 입력된 데이터를 반대로 처리 ex) 1, 2, 3  cw->  3, 2, 1 
 */
namespace Ch07
{
    internal class _1_Stack
    {
        static void Main1(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
