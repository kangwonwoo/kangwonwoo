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
            Console.WriteLine("1. 152");

            Console.WriteLine("2. Hello C# Programing..!");

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

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);

            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

        }
    }
}
