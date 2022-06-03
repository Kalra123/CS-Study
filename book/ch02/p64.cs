using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p64
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(52 + 273);
            // 325를 출력
            Console.WriteLine(5 + 3 * 2);
            // 우선순위를 둠으로써 11이라고 출력
            Console.WriteLine((5 + 3) * 2);
            // 우선순위를 괄호를 침으로 정하였기 때문에, 16으로 출력
            Console.WriteLine(10 / 5);
            Console.WriteLine(7/3);
            // 정수끼리 연산하면 정수로 답이 나옴. 소수점을 짜름
            Console.WriteLine(10%5);
            Console.WriteLine(7%3);
            // 나머지 연산자

        }
    }
}
