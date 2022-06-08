using ch05.sub1; //ctrl + .
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/06/08
 * 이름 조진호
 * 내용 클래스와 객체 실습하기 교제 p203
 * 
 * 클래스와 객체 
 * - 클래스는 객체를 생성하는 구조체이며, 필드와 메서드로 구성된다.
 * - 객체는 클래스의 실제 인스턴스이며, new 연산자로 생성한다.
 * 
 */
namespace ch05
{
    internal class _1_Class
    {
        public static object BWM { get; private set; }

        static void Main(string[] args)
        {
            // 객체 생성
            Car sonata = new Car();

            // 객체 초기화
            sonata.Name = "소나타";
            sonata.Color = "흰색";
            sonata.Speed = 0;

            // 객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            // 객체 생성 (BMW, 검정색)
            BMW M340i = new BMW();

            BMW.BMWName = "BMW 340i";
            BMW.BMWColor = "Green";
            BMW.BMWSpeed = 0;

            // Account 객체생성
            Account kb = new Account();
            kb.Bank = "국민은행"
            kb.Id = "101-12-1234";
            kb.Name = "김유신"
            kb.Balance = 10000;

            //기능
            kb.Deposit = (25000);
            kb.Withdraw = (5000);
            kb.Show();


        }
    }
}
