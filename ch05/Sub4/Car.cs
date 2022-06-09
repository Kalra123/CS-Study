using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch05.Sub3
{
    internal class Car      //car 라는 그룹, 클래스 하위 매개변수와 메서드 총합 6개
    {
        // 속성(필드)
        public string Color;   //멤버변수, 매개변수라는 필드를 만들어놓음
        public int Speed;       //접근 권한자 public
        public string Name;



        // 기능 (메서드)
        public void SpeedUp(int Speed)      //여기서는 메서드의 매개변수 언더바를 통해 구분지을수도 있음
        {
            this.Speed += Speed;       //this.를 붙임으로써 매개변수 언더바보다 더 직관적으로 보이게끔 만든다.
        }       //' 선언' 을 함으로써, 기능을 만들어놓음
        public void SpeedDown(int Speed) 
        {
            this.Speed -= Speed;
        }     //멤버 메서드
        public void Show () 
        {
            Console.WriteLine("===================");
            Console.WriteLine("차량명 :" +Name);
            Console.WriteLine("차량 색깔 : "+Color);
            Console.WriteLine("챠량 속도 : "+Speed);
        }
    }
    internal class BMW
    {
        // 속성,필드
        private string BMWName;
        private string BMWColor;
        private int BMWSpeed;
        private static int count;       //정적변수
        
        // Getter, Setter --> C#에서는 프로퍼티
        public string Name { get { return Name; } set { Name = value; }}
        public string Color { get { return Color; } set { Color = value; }}
        public string Speed { get { return Speed; } set { Speed = value; }}

        


        // 생성자
        public BMW(string BMWName, string BMWColor, int BMWSpeed)
        {
            this.BMWName = BMWName;
            this.BMWColor = BMWColor;
            this.BMWSpeed = BMWSpeed;

        }
        // 소멸자
        ~BMW()
        {
            Console.WriteLine("{0} BMW 소멸자 실행.", Name);
        }


        public void SpeedUp(int Speed)
        {
            this.BMWSpeed += Speed;
        }
        public void SpeedDown(int Speed)
        {
            this.BMWSpeed -= Speed;
        }
        public void Show ()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("차량명 :"+BMWName);
            Console.WriteLine("차량 색깔 :" + BMWColor);
            Console.WriteLine("차량 속도 :"+BMWSpeed);
            Console.WriteLine("전체 차량 수:".Count++);
        }

    }
}
