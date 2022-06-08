using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/02
 * 이름 조진호
 * 내용 자료형(data type) 실습하기 교재 p63
 * 
 * 자료형(data type)
 *  - 변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언 
 *  - 자료형은 크게 기본형과 참조형으로 나뉨
 *  
 */

namespace ch02
{
    internal class _2_datatype
    {
        static void Main1(string[] args)
        {
            //정수형
            sbyte num1 = 127;  //1sbyte
            byte num2 = 255;    //1byte
            short num3 = 32767; //2byte
            int num4 = 2147483647;    //4byte
            long num5 = 2147483648;     //8byte

            Console.WriteLine("sbyte :"+num1);
            Console.WriteLine("byte :"+num2);    
            Console.WriteLine("short :"+num3);
            Console.WriteLine("int :"+num4);
            Console.WriteLine("long :"+num5);


            //실수형
            float var1 = 1.123456678f;
            double var2 = 1.12345667891123456789;

            Console.WriteLine("float :"+var1);
            Console.WriteLine("double :"+var2);

            //논리형
            bool b1 = true;
            bool b2 = false;   

            Console.WriteLine("bool :"+b1);
            Console.WriteLine("bool :"+b2);

            //문자형
            char c1 = 'a';
            char c2 = '가';

            Console.WriteLine("char :"+c1);
            Console.WriteLine("char :"+c2);

            //문자열
            string str1 = "a";
            string str2 = "가";
            string str3 = "apple";
            string str4 = "안녕하세요";
            string str5 = "10";

            Console.WriteLine("str1 :"+str1);
            Console.WriteLine("str2 :"+str2);
            Console.WriteLine("str3 :"+str3);
            Console.WriteLine("str4 :"+str4);
            Console.WriteLine("str5 :"+str5);

            //object형
            object obj1 = 11;
            object obj2 = 3.141592;
            object obj3 = true;
            object obj4 = 'a';
            object obj5 = "apple";

            Console.WriteLine("obj1 : " + obj1);
            Console.WriteLine("obj2 : " + obj2);
            Console.WriteLine("obj3 : " + obj3);
            Console.WriteLine("obj4 : " + obj4);
            Console.WriteLine("obj5 : " + obj5);


            //var형
            var v1 = 11;
            var v2 = 3.141592;
            var v3 = true;
            var v4 = 'a';
            var v5 = "apple";

            Console.WriteLine("v1 :" + v1);
            Console.WriteLine("v2 :" + v2);
            Console.WriteLine("v3 :" + v3);
            Console.WriteLine("v4 :" + v4);
            Console.WriteLine("v5 :" + v5);



        }

    }
}
