using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch02
{
    internal class p92
    {
        static void Main1(string[] args)
        {
            string output = "hello";
            output += "world";
            output += "!";

            Console.WriteLine(output); 
        }
        static void Main2(string[] args)
        {
            string output = "hello";
            output = output + "world";
            output = output + "!";

            Console.WriteLine(output);
        }
    }
}
