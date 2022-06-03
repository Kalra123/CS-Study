using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class 응용
    {
        static void Main(string[] args)
        {
            int a = 110;
            int b = 98;
            int c = 90;
            int d = 87;
            int x = (a + b + c + d);

            int e = 10;
            int f = 10;
            int g = 10;
            int h = 10;
            int y = (e + f + g + h);

            if (a > e)
            {
                
                Console.WriteLine("힘 스탯 조건 부합");
            }
            else if (b > f)
            {
                
                Console.WriteLine("민첩 스탯 조건 부합");
            }
            else if (c > g)
            {
                
                Console.WriteLine("지능 스탯 조건 부합");

            }
            else if (d > h)
            {
                
                Console.WriteLine("행운 스탯 조건 부합");

            }
            else if (x > y)
            {
                
                Console.WriteLine("스탯 요구치 미달");
            }
            else
            {
                Console.WriteLine("착용 가능");
            }
        }
    }
}
