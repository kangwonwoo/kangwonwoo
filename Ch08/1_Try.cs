using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/20 
 * 이름 : 강원우
 * 내용 : 예외처리 실습하기 교재 p467
 */
namespace Ch08
{
    class Apple
    {
        public void Show()
        {
            Console.WriteLine("Apple Show...");
        }
    }

    internal class _1_Try
    {
        static void Main1(string[] args)
        {
            //////////////////////////////////////////////
            //  try-catch
            //////////////////////////////////////////////
            //  상황1 : 어떤 수를 0으로 나눌 때

            int num1 = 1;
            int num2 = 0;
            int rs1 = 0, rs2 = 0, rs3 = 0, rs4 = 0;

            try
            {
                //  예외가 발생할 수 있는 코드
                rs1 = num1 + num2;
                rs2 = num1 - num2;
                rs3 = num1 * num2;
                rs4 = num1 / num2;  // try 블록에서만 참조되는 지역변수여서 참조값 int rs1 ~ 4=0; 값을 준다.
            }
            catch(Exception e)
            {
                //  예외가 발생 했을 때 처리 할 코드
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("rs1 : "+rs1);
            Console.WriteLine("rs2 : "+rs2);
            Console.WriteLine("rs3 : "+rs3);
            Console.WriteLine("rs4 : "+rs4);

            //  상황 2 : 배열의 인덱스 범위를 벗어났을 때
            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(arr[i] + " ");  //  배열에 0 ~ 4번까지 밖에 없기때문에 5번째 부터는 에러가 발생
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //  상황 3 : NULL 포인트 에러
            Apple a1 = new Apple();
            Apple a2 = null;

            try
            {
                a1.Show();
                a2.Show();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //////////////////////////////////////////////
            //  try-catch-finally
            //////////////////////////////////////////////

            try
            {
                //  예외가 발생할 가능성이 있는 코드
                Console.WriteLine("try...");
            }
            catch(Exception e)
            {
                //  예외가 발생 했을 때 처리 코드
                Console.WriteLine("catch...");
            }
            finally
            {
                //  예외발생 여부와 상관없이 무조건 처리되어야 할 코드
                Console.WriteLine("finally...");
            }

            Console.WriteLine("프로그램 종료...");
        }
    }
}
