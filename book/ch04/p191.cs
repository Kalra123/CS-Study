using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch04
{
    internal class p191
    {
        static void Main1(string[] args)
        {
            int i = 10;
            while (i ==> 0)
            {
                Console.WriteLine(i);
            }
        }
        static void Main2(string[] args)
        {
            int i = 10;
            while ((i--)>0)
            {
                Console.WriteLine(i);
            }    
        }
    }
}
