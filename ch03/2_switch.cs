using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/03
 * 이름 조진호
 * 내용 조건문 실습 교재 p127
 */
namespace ch03
{
    internal class _switch
    {
        static void Main1(string[] args)
        {
            Console.Write("점수 입력 : ");
            string strscore = Console.ReadLine();

            int score = int.Parse(strscore);
            int grade = score / 10;

            switch (grade)
            {
                case 10:
                    Console.WriteLine("A+ 입니다.");
                    break;
                case 9:
                    Console.WriteLine("A 입니다.");
                    break;
                case 8:
                    Console.WriteLine("B 입니다.");
                    break;
                case 7:
                    Console.WriteLine("C 입니다.");
                    break;
                case 6:
                    Console.WriteLine("D 입니다.");
                    break;
                default:
                    Console.WriteLine("F 입니다.");
                    break;
            }
               
        }
    }
}
