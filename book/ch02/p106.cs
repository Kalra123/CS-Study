using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p106
    {
        static void Main(string[] args)
        {
            // long 자료형을 int 자료형으로 변환합니다.
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = longNumber;
            Console.WriteLine(intNumber);

            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;
        
        }
               
    }
}
