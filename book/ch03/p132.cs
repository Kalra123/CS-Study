using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p132
    {
        /* if (불_표현식)
         * {
         *      문장;
         * }
         *else
         *{
         *      문장;
         *}
      *}
      *else
      *{
      *     if (불_표현식)
      *     {
      *         문장;
      *     }
      *     else
      *     {
      *         문장;
      *     }
      *}
      */
        static void Main1(string[] args)
        {
            if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");

            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }
        }
    }
}
