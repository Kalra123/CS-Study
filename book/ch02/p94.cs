﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p94
    {
        static void Main1(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
        }
        static void Main2(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);
        }
    }
}
