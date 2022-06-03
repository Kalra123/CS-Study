using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/03
 * 이름 조진호
 * 내용 문자열(string) 처리 실습 교재 p112
 */
namespace ch02
{
    internal class _6_string
    {
        static void Main1(string[] args)
        {
            string greeting = "good morning";
            Console.WriteLine("greeting :" + greeting);
            Console.WriteLine();

            //문자열 길이
            Console.WriteLine("greeting 길이 : " + greeting.Length);
            Console.WriteLine();

            //문자열 추출
            Console.WriteLine("greeting[0] : " + greeting[0]);
            Console.WriteLine("greeting[3] : " + greeting[3]);
            Console.WriteLine("greeting[5] : " + greeting[5]);
            Console.WriteLine();

            //indexof 문자의 index 번호를 찾는다
            Console.WriteLine("indexOf 'g' :" + greeting.IndexOf('g'));
            Console.WriteLine("indexOf \"o\" :" + greeting.IndexOf("o"));
            Console.WriteLine("indexOf 'o' :" + greeting.IndexOf('o'));
            Console.WriteLine("indexOf \"mor\" :" + greeting.IndexOf("mor"));
            Console.WriteLine("indexOf \"ing\" :" + greeting.IndexOf("ing"));
            Console.WriteLine();
            //lastindex01 문자의 index '마지막'번호를 찾는다
            Console.WriteLine("lastindexof 'g' :" + greeting.LastIndexOf('g'));
            Console.WriteLine("lastindexof 'o' :" + greeting.LastIndexOf('o'));
            Console.WriteLine("lastindexof \"mor\" :" + greeting.LastIndexOf("mor"));
            Console.WriteLine("lastindexof \"ing\"' :" + greeting.LastIndexOf("ing"));
            Console.WriteLine();
            //substring
            Console.WriteLine("substring(0,4) : {0}", greeting.Substring(0, 4));
            Console.WriteLine("substring(5,7) : {0}", greeting.Substring(5, 7));
            Console.WriteLine("substring(5) : {0}", greeting.Substring(5));
            Console.WriteLine();
            //replace 문자를 교체한다
            string replaced = greeting.Replace("morning", "afternoon");
            Console.WriteLine("replaced : " + replaced);
            Console.WriteLine();

            //기본형 데이터 (정수 int, 실수 double, 논리 bool, 문자 char를 문자열로 변환 p112
            int var1 = 1;
            double var2 = 2.12;
            bool var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = ""+var3;

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine(); 


            //문자열 데이터를 기본형으로 변환

            string s1 = "3";
            string s2 = "3.14";
            string s3 = "false";

            int r1 = int.Parse(s1);
            double r2 = double.Parse(s2);
            bool r3 = bool.Parse(s3);

            Console.WriteLine($"r1 : {r1}");
            Console.WriteLine($"r2 : {r2}");
            Console.WriteLine($"r3 : {r3}");
            Console.WriteLine();

        }
    }
}
