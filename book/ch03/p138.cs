using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p138
    {
        static void Main1(string[] args)
        {
            /*switch (비교할 값)
             * {
             *      case 값:
             *      문장
             *      break;
             *      case 값:
             *      문장
             *      break;
             *      default:
             *      문장
             *      break;
             * }
             */
            // 변수를 선언합니다
            Console.Write("숫자를 입력하시오");
            int input = int.Parse(Console.ReadLine());

            //조건문
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
            }
        }


    }
}
