using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon._01단계
{
    internal class Main1_10
    {
        static void Main(string[] args)
        {
            string greeting = "beakjoon";
            Console.ReadLine();
            Console.WriteLine("beakjoon");
            Console.WriteLine("substring(0,8) : {0}", greeting.Substring(0, 8));
            string greeting1 = "baekjoon??!";
            Console.ReadLine();
            Console.WriteLine("baekjoon??!");
            Console.WriteLine("substring(0,11) : {0}", greeting1.Substring(0, 11));
        }
        
    }
}
