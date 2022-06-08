using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p75
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            // 논리부정 연산자
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
            // 논리곱 연산자
            Console.WriteLine(52 && 273);
        }
    }
}
