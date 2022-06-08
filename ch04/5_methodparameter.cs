using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/07
 * 이름 조진호
 * 내용 메서드 출력전용 매개변수
 */
namespace ch04
{
    internal class _5_methodparameter
    {
        static void Main1(string[] args)
        {
            // ref 매개변수
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            Divider1(num1, num2, ref num3, ref num4);

            Console.WriteLine("몫 : {0}, 나머지 : {1}", num3, num4);


            // out 매개변수



        }

        public static void Divider1(int a, int b, ref int quotient, ref int remainder)      // ref 변수 \ 레퍼런스 주소값
        {
            quotient = a / b;
            remainder = a % b;
        }

        public static void Divider2(int a, int b, ref int quotient, ref int remainder)
        {
            quotient = a / b;
            remainder = a % b;

        }
    }
}
