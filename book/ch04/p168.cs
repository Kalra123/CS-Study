﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p168
    {
        static void Main1(string[] args)
        {
            // 변수를 선언합니다.
            int output = 1;

            // 반복을 수행합니다.
            for (int i = 1; i<=20; i++)
            {
                output *= 1;

            }

            // 출력합니다.
            Console.WriteLine(output);
            
        }
        static void Main2(string[] args)
        {
            for (int i = '가'; i <= '힣'; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
