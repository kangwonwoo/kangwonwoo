using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15 
 * 이름 : 강원우
 * 내용 : 컬렌션 HashSet 실습
 * 
 * HashSet : 입력되는 데이터의 순서를 고려하지 않고, 중복을 허용하지 않는 자료구조
 *  - 중복된 데이터를 제거하거나 이미 데이터가 존재하는지 검사 할 때 사용
 */
namespace Ch07
{
    internal class _5_HashSet
    {
        static void Main(string[] args)
        {
            // 집합 생성
            HashSet<int> set = new HashSet<int>();

            //데이터 입력
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(2);
            set.Add(3);

            //데이터 출력
            Console.WriteLine("집합 원소 갯수 : "+set.Count);

            foreach(int n in set)
            {
                Console.WriteLine(n+" ");
            }
            Console.WriteLine();


            // 집합 연산
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5};
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6, 7};

            var result1 = set1.Intersect(set2);  // 교집합 : Intersect
            var result2 = set1.Union(set2);      // 합집합 : Union
            var result3 = set1.Except(set2);     // 차집합 : Except

            foreach(int n in result1)
                Console.Write(n+" ");
            Console.WriteLine();

            foreach (int n in result2)
                Console.Write(n + " ");
            Console.WriteLine();

            foreach (int n in result3)
                Console.Write(n + " ");
            Console.WriteLine();



        }
    }
}
