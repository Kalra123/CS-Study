using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    class Program111
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }
    }

    internal class p186
    {
        static void Main1(string[] args)
        {
            Console.Write("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
        }
    }
    

}
