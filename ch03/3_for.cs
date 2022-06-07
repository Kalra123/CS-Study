using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    internal class _for
    {
        static void Main1(string[] args)
        {
            // for문 = for (초기식, 조건식, 증감식)
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("(0)회를 반복...", i);
            }

            // 1부타 10까지 합
            int sum = 0;

            for (int k = 1; k <= 10; k++)
            {
                sum += k;

            }
            Console.WriteLine("1부터 10까지의 합 : " + sum);

            // 부터 10까지 짝수합
        }

            
        
    }
}
