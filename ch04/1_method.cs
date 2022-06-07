using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/07
 * 이름 조진호
 * 내용 매서드에 대한 이해
 */
namespace ch04
{
    internal class _1_method
    {
        static void Main1(string[] args)     //메인 함수에서 메서드를 호출한다
        {
            
            
            //메서드 호출
            int r1 = f(1);
            int r2 = f(2);
            int r3 = f(3);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);

            //메서드 호출 
            int t1 = Sum(1, 10);
            int t2 = Sum(1, 100);
            int t3 = Sum(start: 1, end: 1000);

            Console.WriteLine("t1 : " + t1);
            Console.WriteLine("t2 : " + t2);
            Console.WriteLine("t3 : " + t3);


        }// main end
        
        public static int f(int x)     //f라는 함수에 int (정수)로 출력한다
        {
            int y = 2 * x + 3;
            return y;       
        }
        // 매서드 정의
        public static int Sum (int start, int end)
        {
            int total = 0;
            for (int k = start; k < end; k++)
            {
                total += k;

            }
            return total;
        }
    }
}
