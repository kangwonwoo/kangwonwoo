using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch05
{
    internal class p235
    {
        class Program
        {
            class Student
            {
                public string name;
                public int grade;
            }

            static void Main235(string[] args)
            {
                List<Student> list = new List<Student>();
                list.Add(new Student() { name = "윤인성", grade = 1});
                list.Add(new Student() { name = "연하진", grade = 2});
                list.Add(new Student() { name = "윤아린", grade = 3});
                list.Add(new Student() { name = "윤명월", grade = 4});
                list.Add(new Student() { name = "구지연", grade = 1});
                list.Add(new Student() { name = "김연화", grade = 2});

                // foreach 반복문으로 요소 제거 --> 제거 불가 에러
                foreach(var item in list)
                {
                    if (item.grade > 1)
                    {
                        list.Remove(item);
                    }
                }

                foreach(var item in list)
                {
                    Console.WriteLine(item.name + " : " + item.grade);
                }

                // for 반복문으로 요소 제거 후 --> 제거 가능
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].grade > 1)
                    {
                        list.RemoveAt(i);
                    }
                }

                foreach (var item in list)
                {
                    Console.WriteLine(item.name + " : " + item.grade);
                }

                // 역 for 반복문을 사용한 요소 제거
                for (int i = list.Count - 1; i >=0; i--)
                {
                    if (list[i].grade > 1)
                    {
                        list.RemoveAt(i);
                    }
                }

                foreach (var item in list)
                {
                    Console.WriteLine(item.name + " : " + item.grade);
                }
            }
        }
    }
}

