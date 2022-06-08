using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class 낙서장
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. 152");  // 152

            Console.WriteLine("2. Hello C# Programing..!");  // Hello C# Programing..!

            Console.WriteLine("3. "+(32 + 273));  // 305

            Console.WriteLine("4. "+(5 + 3 * 2));  // 11

            Console.WriteLine("5. "+(10 % 5));  // 0
            Console.WriteLine("6. "+(7 % 3));  // 1

            Console.WriteLine("7. "+(1 + 2));  // 3
            Console.WriteLine("8. "+(1 - 2));  // -1
            Console.WriteLine("9. "+(1 * 2));  // 2
            Console.WriteLine("10. "+(1 / 2));  // 0.5
            Console.WriteLine("11. "+(1 % 2));  // 1

            Console.WriteLine("12. "+(4 % 3));   // 1
            Console.WriteLine("13. "+(-4 % 3));   // -1
            Console.WriteLine("14. "+(4 % -3));   // 1
            Console.WriteLine("15. "+(-4 % -3));   // -1

            Console.WriteLine("16. "+(52.273));   // 52.273

            Console.WriteLine("17. "+(0));    // 0
            Console.WriteLine("18. "+(0.0));   // 0

            Console.WriteLine("19. "+(1.0 + 2.0));   // 3
            Console.WriteLine("20. "+(1.0 - 2.0));   // -1
            Console.WriteLine("21. "+(1.0 * 2.0));   // 2
            Console.WriteLine("22. "+(1.0 / 2.0));   // 0.5

            Console.WriteLine("23. "+(5.0 % 2.2));   // 0.6

            Console.WriteLine("24. "+('A'));   // A
            Console.WriteLine("25. "+('가'));   // 가
            Console.WriteLine("26. "+('나'));   // 나

            Console.WriteLine("27. "+("안녕하세요"));   // 안녕하세요

            Console.WriteLine("28. "+("한빛\t아카데미"));   // 한빛       아카데미
            Console.WriteLine("29. "+("한빛\n아카데미"));   // 한빛
                                                           // 아카데미
            Console.WriteLine("30. "+("\"\"\""));    // """ p70

            Console.WriteLine("31. "+("가나다" + "라마바사" + "아자차카" + "파하"));   // 가나다라마바사아자차카타파하

            Console.WriteLine("안녕하세요"[0]);  // 안
            Console.WriteLine("안녕하세요"[3]);  // 세
            Console.WriteLine("안녕하세요"[4]);  // 요

            Console.WriteLine('가' + '힣');  // 99235

            Console.WriteLine(true);  // true
            Console.WriteLine(false);  // false

            Console.WriteLine(52 < 273);  // true
            Console.WriteLine(52 > 273);  // false

            Console.WriteLine(!true);  //false
            Console.WriteLine(!false);  // true
            Console.WriteLine(!(52 < 273));  // false
            Console.WriteLine(!(52 > 273));  // true

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);  // 시간대마다 다르다.
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);  // 시간대마다 다르다.

            int a1 = 273;
            int b1 = 52;

            Console.WriteLine(a1 + b1);  // 325
            Console.WriteLine(a1 - b1);  // 221
            Console.WriteLine(a1 * b1);  // 14196
            Console.WriteLine(a1 / b1);  // 5
            Console.WriteLine(a1 % b1);  // 13

            int a2 = 2147483640;
            int b2 = 52273;

            Console.WriteLine(a2 + b2);  // -2147431383  --> int 범위의 한계를 넘어서 '오버플로우' 현상

            int a3 = 2000000000;
            int b3 = 1000000000;
            Console.WriteLine(a3 + b3);  // -1294967296  --> 오버플로우

            double a4 = 52.273;
            double b4 = 103.32;

            Console.WriteLine(a4 + b4);  // 155.593
            Console.WriteLine(a4 - b4);  // -51.047
            Console.WriteLine(a4 * b4);  // 5400.84636
            Console.WriteLine(a4 / b4);  // 0.50593302361595

            Console.WriteLine("int : "+ sizeof(int));         // int : 4
            Console.WriteLine("long : "+ sizeof(long));       // long : 8
            Console.WriteLine("double : "+ sizeof(double));   // double : 8
            Console.WriteLine("float : "+ sizeof(float));     // float : 4
            Console.WriteLine("char : "+ sizeof(char));       // char : 2

            char a5 = 'a';
            char b5 = 'b';

            Console.WriteLine(a5 + b5);  // 195
            Console.WriteLine(a5 - b5);  // -1
            Console.WriteLine(a5 * b5);  // 9506
            Console.WriteLine(a5 / b5);  // 0
            Console.WriteLine(a5 % b5);  // 97

            string message = "안녕하세요";

            Console.WriteLine(message + "!");  // 안녕하세요!
            Console.WriteLine(message[0]);     // 아
            Console.WriteLine(message[1]);     // 녕
            Console.WriteLine(message[2]);     // 하

            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);
        }
    }
}
