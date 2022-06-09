using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub4
{
    internal class Sedan : Car      //Sedan이 Car에게 참조하려 한다. Car 에서 Sedan 에게 참조할 수 있도록 protected로 바꿔줘야함
    {
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차량 명 : "+Name);
            Console.WriteLine("차량 색 : "+Color);
            Console.WriteLine("차량 속도 : "+Speed);
            Console.WriteLine("차량 배기량 : "+cc);
            Console.WriteLine("================");
        }
    }
}
