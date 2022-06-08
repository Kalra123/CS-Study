using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p135
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");

            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");

            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");

            }
        }
        static void Main(string[] args)
        {
            //학점 변수
            double score = 3.6;
            //조건을 구분합니다.
            if (score == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score && score < 4.5)
                Console.WriteLine("교수님의 사랑");
            else if (3.5 <= score && score < 4.2)
                Console.WriteLine("현 체제의 수호자");
            else if (2.8 <= score && score < 3.5)
                Console.WriteLine("일반인");

        }
    }
}
