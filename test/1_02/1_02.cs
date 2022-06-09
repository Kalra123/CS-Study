using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test._1_02
{
    internal class _1_02
    {
        static void Main(string[] args)
        {
            int year;
            int birth;
            string name;

            Console.Write("올해 년도 입력 : ");
            year = int.Parse(Console.ReadLine());

            Console.Write("태어난 년도 입력 : ");
            birth = Convert.ToInt32(Console.ReadLine());

            Console.Write("이름 입력 : ");
            name = Console.ReadLine();

            int age = year - birth;
        }
    }
}
