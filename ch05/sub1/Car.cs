using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.sub1
{
    internal class car      //car 라는 그룹, 클래스 하위 매개변수와 메서드 총합 6개
    {
        // 속성(필드)
        public string color;   //멤버변수, 매개변수라는 필드를 만들어놓음
        public int speed;       //접근 권한자 public
        public string name;


        // 기능 (메서드)
        public void speedup(int speed)      //여기서는 메서드의 매개변수 언더바를 통해 구분지을수도 있음
        {
            this.speed += speed;       //this.를 붙임으로써 매개변수 언더바보다 더 직관적으로 보이게끔 만든다.
        }       //' 선언' 을 함으로써, 기능을 만들어놓음
        public void speeddown() 
        {
            this.speed -= speed;
        }     //멤버 메서드
        public void show () 
        {
            Console.WriteLine("===================");
            Console.WriteLine("차량명 :" +name);
            Console.WriteLine("차량 색깔 : "+color);
            Console.WriteLine("챠량 속도 : "+speed);
        }
    }
}
