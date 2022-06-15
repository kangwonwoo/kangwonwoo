using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15 
 * 이름 : 강원우
 * 내용 : 컬렌션 큐 실습
 * 
 * Queue : 순서대로 입력된 데이터를 차례대로 처리( 선입선출 )
 */
namespace Ch07
{
    internal class _2_Queue
    {
        static void Main2(string[] args)
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("1");
            que.Enqueue("2");
            que.Enqueue("3");
            que.Enqueue("4");
            que.Enqueue("5");

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
