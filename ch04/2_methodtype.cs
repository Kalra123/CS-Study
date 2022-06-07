using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/07
 * 이름 조진호
 * 내용 메서드 타입 실습하기 교재 p265
 */
namespace ch04
{
    internal class _2_methodtype
    {
        static void Main1(string[] args)
        {
            //메서드 호출
            double y1 = type1(0.1);     //인자값 0.1 대입
            double y2 = type1(1.2);

            Type2(true);
            Type2(false);

            string result = Type3();
            Console.WriteLine("Type3 result : "+result);

            Type4();


        }

        // Type1 : 매개변수 0 , 리턴값 0
        public static double type1(double x)
        {
            double y = x + 3.14;
            return y;
        }
        // Type2 : 매개변수 0 , 리턴값 x
        public static void Type2(bool status) // type2의 리턴값은 void에 의해 리턴값이 없음
        {
            if (status)
            {
                Console.WriteLine("참 입니다.");

            }
            else
            {
                Console.WriteLine("거짓 입니다.");
            }
        }
        // Type3 : 매개변수 x , 리턴값 0
        public static string Type3()
        {
            int n1 = -1, n2 = 2;

            if (n1 > n2)

                return "n1은 n2보다 크다.";
            else
                return "n1은 n2보다 작다.";
        }


        // Type4 : 매개변수 x , 리턴값 x
        public static void Type4()
        {
            double result = type1(1.121);
            Console.WriteLine("Type4 result : " + result);

        }
    }
}
