using ch06.Sub07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/13
 * 이름 조진호
 * 내용 인터페이스 실습 교재 p425
 * 
 * 인터페이스 (interface)
 * - 클래스 간의 공통의 통일된 표준 규격을 통해 클래스 구조를 설계하는 문법
 * - 인터페이스를 활용해서 다중 상속을 구현
 * = 인터페이스를 활용해서 객체간 결합도를 완화하는 효과를 얻는다. (다형성)
*/
namespace ch06
{
    internal class _2_Interface
    {
        static void Main(string[] args)
        {

            // 인터페이스로 공동 클래스 구조설계
            IRemoteControl lg = new LGRemocon();
            IRemoteControl samsung = new ISamsungRemocon();

            lg.PowerOn();
            lg.PowerOff();
            lg.ChDown();
            lg.ChUp();

            samsung.PowerOn();
            samsung.ChDown();
            samsung.ChUp();
            samsung.PowerOff();


            // 인터페이스를 활용한 다중 상속
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();

            //인터페이스를 활용한 결합도 완화
            Bulb bulb = new Bulb();
            ISocket socket = new Cable(bulb);

            cable.SwitchOn();
            cable.SwitchOff();

        }
                
    }
}
