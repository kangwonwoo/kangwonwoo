using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/15 
 * 이름 : 강원우
 * 내용 : 컬렌션 스택 실습
 * 
 * ArrayList
 * - 배열과 유사한 선형 자료구조
 * - List는 ArrayList를 일반화 시킨 자료구조 ArrayList보다 더 나은 성능
 */
namespace Ch07
{
    internal class _3_ArrayList
    {
        // ArrayList는(일반클래스) 배열과 유사한 동적 선형 자료구조
        // ( 입력되는 데이터에 따라 크기가 늘어나며 각 데이터를 처리 할 수 있는 기능 제공
        // List는(제네릭 클래스) ArrayList를 일반화 시킨 컬렉션

        static void Main3(string[] args)
        {
            ///////////////////////////////////////
            // ArrayList 생성
            ArrayList list1 = new ArrayList();  // ArrayList를 (ctrl + .)로 (using System.Collections;) 추가 해줘야함

            // 데이터 입력
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);   // 1 2 3 4 5 로 출력


            // 데이터 출력
            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();


            // 데이터 삽입
            list1.Insert(1, 6);  // 1자리 바로 뒤에 6 이 같이 출력


            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();


            // 데이터 삭제
            list1.Remove(6);


            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();


            // 데이터 삭제
            list1.RemoveAt(0);


            foreach (int n in list1)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();


            // 다양한 형식의 데이터를 갖는 ArrayList ( 배열은 하나 의 개념만 가능하지만 ArrayList 다양하게 가능하다)
            ArrayList list2 = new ArrayList();

            list2.Add(100);
            list2.Add(0.123);
            list2.Add(true);
            list2.Add('A');
            list2.Add("Apple");

            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }


            /////////////////////////////////////////////
            // List  교재 p211
            /////////////////////////////////////////////
            List<int> list3 = new List<int>();

            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.Add(4);
            list3.Add(5);

            foreach(int n in list3)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();


            List<string> list4 = new List<string>();
            list4.Add("김유신");
            list4.Add("김춘추");
            list4.Add("장보고");
            list4.Add("강감찬");
            list4.Add("이순신");

            foreach (string n in list4)
            {
                Console.Write(n+ " ");
            }
            Console.WriteLine();


            // 사과 객체 리스트
            List<Apple> list5 = new List<Apple>();

            list5.Add(new Apple("한국", 3000));
            list5.Add(new Apple("미국", 2000));
            list5.Add(new Apple("일본", 1000));

            // 사과 데이터 출력
            Apple a1 = list5[0];
            a1.show();
            list5[1].show();
            list5[2].show();


            // HashTable은 키와 값(key-value)의 쌍으로 이루어진 자료 구조
            // table : 표를 나타냄
        }
    }
}
