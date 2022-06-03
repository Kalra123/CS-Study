using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/03
 * 이름 조진호
 * 내용 c# 입력하기 실습 교재 p104
 */
namespace ch02
{
    internal class _4_input
    {
        static void Main1(string[] args)
        {
            // 이름 입력
            Console.Write("이름 :");
            Console.Write("나이 :");
            Console.Write("주소 :");

            string name = Console.ReadLine();

            Console.WriteLine("==============");
            Console.WriteLine("이름 :"+name);

            // 나이 입력
            Console.WriteLine("나이 : ");
            string age = Console.ReadLine();

            // 주소 입력
            Console.WriteLine("주소 : ");
            string addr = Console.ReadLine();


            Console.WriteLine("==============");
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("주소 : " + addr);


        }
    }
}
